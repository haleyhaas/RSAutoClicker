using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class ScreenshotGenerator : IScripter
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;
        private readonly KeyboardHandler _keyboardHandler;
        private bool _isPaused;
                
        public ScreenshotGenerator(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _inventoryHelper = new InventoryHelper();
            _keyboardHandler = new KeyboardHandler();
            _isPaused = false;
        }

        public void Do()
        {
            // Calculate the time in milliseconds
            long millisecondsSinceReference = (long)DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            _isPaused = _keyboardHandler.CheckPause();


            if (IsKeyPressed(0x45) && !_isPaused) // Virtual Key Code E
            {
                // Capture a screenshot of the active application
                Bitmap screenshot = CaptureActiveApplication();

                // Save the screenshot as a temporary file
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"screenshot_{millisecondsSinceReference}.png");
                screenshot.Save(tempFilePath);

                // Open the screenshot in Paint.NET
                OpenInPaintDotNet(tempFilePath);

                // todo -> doesnt work yet
                //FindColorCoordinates(tempFilePath);                

                Thread.Sleep(1_000);
            }
        }

        private void FindColorCoordinates(string tempFilePath)
        {
            Bitmap screenshot = new Bitmap(tempFilePath);

            // Define the target color (as an RGB tuple)
            Color targetColor = Color.Red;
            int colorThreshold = 10; // Adjust this threshold as needed

            // Initialize a queue for the flood-fill algorithm
            Queue<Point> queue = new Queue<Point>();

            // Initialize a set to keep track of visited pixels
            HashSet<Point> visited = new HashSet<Point>();

            // Initialize variables to track the most densely populated area
            int maxPopulation = 0;
            Point centerOfMaxPopulation = Point.Empty;

            // Iterate through the pixels of the screenshot
            for (int x = 0; x < screenshot.Width; x++)
            {
                for (int y = 0; y < screenshot.Height; y++)
                {
                    Color pixel = screenshot.GetPixel(x, y); // Get the pixel color at (x, y)

                    // Check if the color difference is within the threshold
                    int colorDifference = Math.Abs(pixel.R - targetColor.R) +
                                          Math.Abs(pixel.G - targetColor.G) +
                                          Math.Abs(pixel.B - targetColor.B);

                    if (colorDifference <= colorThreshold && !visited.Contains(new Point(x, y)))
                    {
                        // Start a new flood-fill operation
                        int population = FloodFill(screenshot, new Point(x, y), targetColor, colorThreshold, visited, queue, out var xPopulation);

                        // Check if this region has a higher population
                        if (population > maxPopulation)
                        {
                            maxPopulation = population;
                            centerOfMaxPopulation = new Point(x + xPopulation / 2, y);
                        }
                    }
                }
            }
            // Print the center of the most densely populated area
            if (maxPopulation > 0)
            {
                _mouseHandler.InstantLeftClick(centerOfMaxPopulation.X, centerOfMaxPopulation.Y, noClick: true);
            }

        }

        private static bool IsKeyPressed(int virtualKeyCode)
        {
            return (GetAsyncKeyState(virtualKeyCode) & 0x8000) != 0;
        }

        static Bitmap CaptureActiveApplication()
        {
            // Get the bounds of the active application window
            IntPtr handle = GetForegroundWindow();
            Rectangle bounds;
            GetWindowRect(handle, out bounds);

            // Capture the screenshot
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics gfx = Graphics.FromImage(screenshot))
            {
                gfx.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
            }

            return screenshot;
        }

        static void OpenInPaintDotNet(string filePath)
        {
            // Replace "paintnet.exe" with the actual path to your Paint.NET executable
            string paintDotNetPath = @"C:\Program Files\paint.net\paintdotnet.exe";

            // Check if Paint.NET is installed and the file exists
            if (File.Exists(paintDotNetPath))
            {
                // Start Paint.NET with the screenshot as an argument
                Process.Start(paintDotNetPath, filePath);
            }
        }

        static int FloodFill(Bitmap image, Point seed, Color targetColor, int colorThreshold, HashSet<Point> visited, Queue<Point> queue, out int xPopulation)
        {
            int population = 0;
            xPopulation = 0;
            queue.Enqueue(seed);
            visited.Add(seed);

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();
                population++;

                // Check neighboring pixels
                var neighbors = GetNeighbors(current, image.Width, image.Height).ToList();
                for(var i = 0; i < 4; i++)
                {
                    var neighbor = neighbors[i];
                    if (!visited.Contains(neighbor))
                    {
                        Color neighborColor = image.GetPixel(neighbor.X, neighbor.Y);
                        int colorDifference = Math.Abs(neighborColor.R - targetColor.R) +
                                              Math.Abs(neighborColor.G - targetColor.G) +
                                              Math.Abs(neighborColor.B - targetColor.B);

                        if (colorDifference <= colorThreshold)
                        {
                            if(i == 0){
                                xPopulation--;
                            }
                            if(i == 1)
                            {
                                xPopulation++;
                            }

                            queue.Enqueue(neighbor);
                            visited.Add(neighbor);
                        }
                    }
                }
            }

            return population;
        }

        static IEnumerable<Point> GetNeighbors(Point point, int width, int height)
        {
            List<Point> neighbors = new List<Point>
            {
                new Point(point.X - 1, point.Y), // Left
                new Point(point.X + 1, point.Y), // Right
                new Point(point.X, point.Y - 1), // Up
                new Point(point.X, point.Y + 1)  // Down
            };

            // Filter out neighbors that are out of bounds
            return neighbors.FindAll(p => p.X >= 0 && p.X < width && p.Y >= 0 && p.Y < height);
        }


        // Import Windows API functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);
    }
}