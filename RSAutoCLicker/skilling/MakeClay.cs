using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// 
    /// </summary>
    public class MakeClay : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public MakeClay(IMouseHandler mouseHandler)
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


            Console.WriteLine($"Doing {nameof(MakeClay)}");
            var p = _mouseHandler.CursorPos();

            // open bank
            _mouseHandler.LeftClick(854, 245, isFast: true);
            Thread.Sleep(800);

            // deposit clay
            _mouseHandler.LeftClick(1517, 753);

            // withdraw clay
            _mouseHandler.LeftClick(878, 350, isFast: true);
            Thread.Sleep(200);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(300);

            // cast humidify
            _mouseHandler.LeftClick(1562, 757, isFast: true);
            Thread.Sleep(1500);

        }
    }
}