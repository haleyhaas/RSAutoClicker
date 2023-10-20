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
            _mouseHandler.LeftClick(938, 750);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1256, 715);

            // withdraw
            _mouseHandler.LeftClick(910, 325);
            Thread.Sleep(400);

            // close
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(500);

            // click items
            _mouseHandler.LeftClick(1245, 679);
            Thread.Sleep(700);
            _mouseHandler.LeftClick(1245, 720);
            Thread.Sleep(800);

            // make all
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
            Thread.Sleep(32_000);
        }
    }
}