using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// 
    /// </summary>
    public class MakePlank : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public MakePlank(IMouseHandler mouseHandler)
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

            var p = _mouseHandler.CursorPos();

            // deposit
            _mouseHandler.LeftClick(1759, 758);

            // withdraw
            _mouseHandler.LeftClick(999, 355, isFast: true);
            Thread.Sleep(200);

            // go to sawmill
            _mouseHandler.LeftClick(1459, 360);
            Thread.Sleep(33_000);

            // talk to sawmill for plank
            _mouseHandler.LeftClick(903, 533, withSleep: true);
            Thread.Sleep(2000);

            // buy planks
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            // return to bank
            _mouseHandler.LeftClick(133, 808, withSleep: true);
            Thread.Sleep(33_000);
        }
    }
}
