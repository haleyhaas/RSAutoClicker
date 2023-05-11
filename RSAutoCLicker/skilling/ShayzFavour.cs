using System.Diagnostics;
using System.Runtime.InteropServices;


namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class ShayzFavour : IScripter
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly Stopwatch _stopwatch;
        public ShayzFavour(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _stopwatch = Stopwatch.StartNew();
            _inventoryHelper = new InventoryHelper();
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {

            var p = _mouseHandler.CursorPos();

            var paused = _keyboardHandler.CheckPause();

            if (GetAsyncKeyState(0x52) != 0 && !paused) // 0x52 is the virtual key code for the R key
            {
                _inventoryHelper.InventoryClear();
            }
        }
    }
}