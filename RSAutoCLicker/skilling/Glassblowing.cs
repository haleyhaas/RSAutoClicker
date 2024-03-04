using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Glassblowing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public Glassblowing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();
            
            // bank
            _mouseHandler.LeftClick(841, 365, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1482, 751, withSleep: true);
                        
            // withdraw
            _mouseHandler.LeftClick(784, 494, withSleep: true);
            Thread.Sleep(200);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(200);

            // make glass
            _mouseHandler.LeftClick(1482, 758, withSleep: true);
            _mouseHandler.LeftClick(1482, 788, withSleep: true);
            Thread.Sleep(1000);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            Thread.Sleep(49_400);

        }
    }
}