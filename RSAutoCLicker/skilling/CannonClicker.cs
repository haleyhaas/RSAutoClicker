using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class CannonClicker : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private bool paused = false;
        public CannonClicker(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CannonClicker)}");
            var p = _mouseHandler.CursorPos();
            
            if (GetAsyncKeyState(0x6A) != 0)
            {
                paused = true;
            }

            if (paused)
            {
                Thread.Sleep(10_000);
                paused = false;
            }
            _mouseHandler.LeftClick(422, 345);
            Thread.Sleep(18_000);
            Thread.Sleep(200);
        }
    }
}