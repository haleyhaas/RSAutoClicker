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
        public BuyFeathers(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _inventoryHelper = new InventoryHelper();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(BuyFeathers)}");
            var p = _mouseHandler.CursorPos();

            // buy feathers
            _mouseHandler.LeftClick(646, 543);
            Thread.Sleep(13_000);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);

            // clear inventory
            _inventoryHelper.InventoryClear();
            Thread.Sleep(1_000);

            // open shop again -> i have to find a shop where the shop keeper doesnt move
            _mouseHandler.LeftClick(646, 543);

        }
    }
}