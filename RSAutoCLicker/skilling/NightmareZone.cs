namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class NightmareZone : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly IInventoryHelper _inventoryHelper;
        public NightmareZone(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _inventoryHelper = new InventoryHelper();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();
           
            // flick rapid heal
            _mouseHandler.LeftClick(1469, 123, withSleep: true);
            _mouseHandler.LeftClick(1469, 123, withSleep: true);

            // clear inventory, every 45 seconds
            Thread.Sleep(1000);
            _inventoryHelper.InventoryClear();
            Thread.Sleep(45_000);
        }
    }
}