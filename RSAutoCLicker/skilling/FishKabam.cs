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
            _mouseHandler.LeftClick(1064, 652, withSleep: true);
            Thread.Sleep(3200);

            // click destination DJR
            _mouseHandler.LeftClick(1373, 787);
            Thread.Sleep(2000);

            // click travel
            _mouseHandler.LeftClick(946, 591);
            Thread.Sleep(3800);

            // click bank
            _mouseHandler.LeftClick(1459, 734, withSleep: true);
            Thread.Sleep(10_800);

            // deposit
            _mouseHandler.LeftClick(1362, 719);
            Thread.Sleep(1000);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);

            // click fairy ring
            _mouseHandler.LeftClick(711, 433, withSleep: true);
            Thread.Sleep(10_800);

            // click destination DKP
            _mouseHandler.LeftClick(1370, 756);
            Thread.Sleep(2000);

            // click travel
            _mouseHandler.LeftClick(946, 591);
            Thread.Sleep(3800);

            // fish for full inventory
            _mouseHandler.LeftClick(1041, 497, withSleep: true);
            Thread.Sleep(105_000);
        }
    }
}
