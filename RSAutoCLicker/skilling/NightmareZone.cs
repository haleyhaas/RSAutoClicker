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
            _mouseHandler.LeftClick(1323, 677);
            Thread.Sleep(30);
            _mouseHandler.LeftClick(1323, 677);
            Thread.Sleep(570);

            //// flick rapid heal
            //_keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F2);
            //Thread.Sleep(1000);
            //_mouseHandler.LeftClick(1250, 750);
            //Thread.Sleep(1000);
            //_mouseHandler.LeftClick(1250, 750);
            //
            //// clear inventory, every 45 seconds
            //_keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);
            //Thread.Sleep(1000);
            //_inventoryHelper.InventoryClear();
            //Thread.Sleep(45_000);
        }
    }
}