using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Fishing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;

        public Fishing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();



            _inventoryHelper.InventoryClear();

        }
    }
}