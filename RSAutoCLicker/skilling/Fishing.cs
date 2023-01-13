namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Fishing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper inventoryHelper;
        public Fishing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            inventoryHelper = new InventoryHelper();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Fishing)}");
            var p = _mouseHandler.CursorPos();

            // fish
            _mouseHandler.LeftClick(814, 803);
            Thread.Sleep(46_000);

            // clear inventory
            inventoryHelper.InventoryClear();


        }
    }
}