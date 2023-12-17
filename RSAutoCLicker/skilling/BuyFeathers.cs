namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class BuyFeathers : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly IInventoryHelper _inventoryHelper;
        private readonly WorldHopper _worldHopper;
        public BuyFeathers(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _inventoryHelper = new InventoryHelper();
            _worldHopper = new WorldHopper(_mouseHandler);
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(BuyFeathers)}");
            var p = _mouseHandler.CursorPos();

            // buy feathers
            _mouseHandler.LeftClick(716, 383);
            Thread.Sleep(1_000);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);

            // clear inventory
            _inventoryHelper.InventoryClear();
            Thread.Sleep(1_000);

            // world hop
            _worldHopper.Do();
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);

            // open shop again -> i have to find a shop where the shop keeper doesnt move
            _mouseHandler.LeftClick(940, 400, withSleep: true);
            Thread.Sleep(1_500);

        }
    }
}