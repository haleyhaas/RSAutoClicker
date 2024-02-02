using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class MakeUnpoweredOrb : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public MakeUnpoweredOrb(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();
            
            // bank
            _mouseHandler.LeftClick(839, 362, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1479, 790, withSleep: true);

            // withdraw glass
            _mouseHandler.LeftClick(735, 639, withSleep: true);
            Thread.Sleep(250);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(200);

            // use 1
            _mouseHandler.LeftClick(1480, 753, withSleep: true);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1480, 788, withSleep: true);
            Thread.Sleep(800);

            // make all
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            Thread.Sleep(49_000);

        }
    }
}