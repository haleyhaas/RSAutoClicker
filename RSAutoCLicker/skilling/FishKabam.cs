using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// 
    /// </summary>
    public class FishKabam : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public FishKabam(IMouseHandler mouseHandler)
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

            // click fairy ring
            _mouseHandler.LeftClick(834, 683, withSleep: true);
            Thread.Sleep(3200);

            // click destination DJR
            _mouseHandler.LeftClick(1489, 857);
            Thread.Sleep(2000);

            // click travel
            _mouseHandler.LeftClick(704, 557);
            Thread.Sleep(3800);

            // click bank
            _mouseHandler.LeftClick(1602, 917, withSleep: true);
            Thread.Sleep(10_800);

            // deposit
            _mouseHandler.LeftClick(1475, 789);
            Thread.Sleep(500);

            // click fairy ring
            _mouseHandler.LeftClick(323, 290, withSleep: true);
            Thread.Sleep(10_800);

            // click destination DKP
            _mouseHandler.LeftClick(1484, 824);
            Thread.Sleep(2000);

            // click travel
            _mouseHandler.LeftClick(704, 557);
            Thread.Sleep(3800);

            // fish for full inventory
            _mouseHandler.LeftClick(814, 424, withSleep: true);
            Thread.Sleep(97_000);
        }
    }
}
