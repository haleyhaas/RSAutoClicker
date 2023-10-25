namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class BuyFish : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public BuyFish(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(BuyFish)}");
            var p = _mouseHandler.CursorPos();

            // click vendor
            _mouseHandler.LeftClick(646, 543, true, true);
            Thread.Sleep(13_400);

            // buy fish
            _mouseHandler.LeftClick(675, 385, true, true);
            Thread.Sleep(400);
            _mouseHandler.LeftClick(715, 385, true, true);
            Thread.Sleep(400);
            _mouseHandler.LeftClick(755, 385, true, true);
            Thread.Sleep(400);
            _mouseHandler.LeftClick(805, 385, true, true);
            Thread.Sleep(400);

            // click bank
            _mouseHandler.LeftClick(1314, 556, true, true);
            Thread.Sleep(15_000);

            // deposit fish, withdraw GP again
            _mouseHandler.LeftClick(1023, 771, true, true);
            Thread.Sleep(400);
            _mouseHandler.LeftClick(669, 246, true, true);
            Thread.Sleep(600);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
        }
    }
}