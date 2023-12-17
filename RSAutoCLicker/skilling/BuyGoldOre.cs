namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class BuyGoldOre : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly WorldHopper _worldHopper;
        public BuyGoldOre(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _worldHopper = new WorldHopper(_mouseHandler);
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(BuyFish)}");
            var p = _mouseHandler.CursorPos();

            for (var i = 0; i < 2; i++)
            {
                // click vendor
                _mouseHandler.LeftClick(615, 305, true, true);
                Thread.Sleep(8_500);

                // buy ore
                _mouseHandler.LeftClick(898, 382, true, true);
                Thread.Sleep(400);
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);

                // click bank
                _mouseHandler.LeftClick(1386, 892, true, true);
                Thread.Sleep(8_500);

                // deposit ore
                _mouseHandler.LeftClick(1292, 673, true, true);
                Thread.Sleep(400);
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            }
            Thread.Sleep(1500);

            // world hop
            _worldHopper.Do();

            Thread.Sleep(1000);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);
            Thread.Sleep(500);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);
            Thread.Sleep(500);
        }
    }
}