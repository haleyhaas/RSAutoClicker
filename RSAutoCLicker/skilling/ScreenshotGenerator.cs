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
            // Create a DateTime representing the current date and time
            DateTime now = DateTime.Now;

            // Define a reference DateTime (e.g., January 1, 1970)
            DateTime referenceDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Calculate the time difference in milliseconds
            long millisecondsSinceReference = (long)(now - referenceDate).TotalMilliseconds;

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

                Thread.Sleep(3_000);
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

        // Import Windows API functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);
    }
}