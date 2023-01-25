using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Fishing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;

        public Fishing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _inventoryHelper = new InventoryHelper();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Thieving)}");
            var p = _mouseHandler.CursorPos();

            // click on fishing spot
            _mouseHandler.LeftClick(650, 613);

            Thread.Sleep(60_000);

            _inventoryHelper.InventoryClear();

        }               
    }
}