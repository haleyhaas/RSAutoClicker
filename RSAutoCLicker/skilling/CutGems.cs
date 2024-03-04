namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class CutGems : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public CutGems(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CutGems)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(838, 392);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(899, 825);

            // withdraw
            _mouseHandler.LeftClick(880, 242, withSleep: true);
            Thread.Sleep(400);
            _mouseHandler.LeftClick(641, 174, withSleep: true);
            Thread.Sleep(400);

            // close
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(500);

            // click items
            _mouseHandler.LeftClick(1485, 753);
            Thread.Sleep(700);
            _mouseHandler.LeftClick(1485, 790);
            Thread.Sleep(800);

            // make all
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
            Thread.Sleep(32_000);
        }
    }
}