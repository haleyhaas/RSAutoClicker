using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// 
    /// </summary>
    public class FletchYewLong : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public FletchYewLong(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            if (_keyboardHandler.CheckPause())
            {
                return;
            }


            Console.WriteLine($"Doing {nameof(FletchYewLong)}");
            var p = _mouseHandler.CursorPos();

            // open bank
            _mouseHandler.LeftClick(787, 283, isFast: true);
            Thread.Sleep(800);

            // deposit inventory
            _mouseHandler.LeftClick(899, 817, isVeryFast: true);

            // withdraw yew bow + bow string
            _mouseHandler.LeftClick(825, 175, isVeryFast: true);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(865, 175, isFast: true);
            Thread.Sleep(100);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(300);

            // use on each other
            _mouseHandler.LeftClick(1476, 860, isVeryFast: true);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1476, 896, isFast: true);
            Thread.Sleep(100);

            // make all
            for (var j = 0; j < 100; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }

            Thread.Sleep(16_000);

        }
    }
}