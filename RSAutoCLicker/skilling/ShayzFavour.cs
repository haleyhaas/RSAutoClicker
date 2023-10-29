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

            // soldier 1 and 2
            _mouseHandler.LeftClick(1259, 680, withSleep: true);
            _mouseHandler.LeftClick(775, 676, withSleep: true);
            Thread.Sleep(3000);
            _mouseHandler.LeftClick(1298, 675, withSleep: true);
            _mouseHandler.LeftClick(909, 673, withSleep: true);
            Thread.Sleep(2000);

            // soldier 3 and 4
            _mouseHandler.LeftClick(1339, 676, withSleep: true);
            _mouseHandler.LeftClick(570, 672, withSleep: true);
            Thread.Sleep(6000);
            _mouseHandler.LeftClick(1382, 677, withSleep: true);
            _mouseHandler.LeftClick(911, 670, withSleep: true);
            Thread.Sleep(2000);

            // soldier 5
            _mouseHandler.LeftClick(1260, 713, withSleep: true);
            _mouseHandler.LeftClick(910, 171, withSleep: true);
            Thread.Sleep(6000);

            // soldier 6 and 7
            _mouseHandler.LeftClick(1296, 717, withSleep: true);
            _mouseHandler.LeftClick(1282, 458, withSleep: true);
            Thread.Sleep(6000);
            _mouseHandler.LeftClick(1343, 714, withSleep: true);
            _mouseHandler.LeftClick(974, 467, withSleep: true);
            Thread.Sleep(2000);

            //soldier 8 and 9
            _mouseHandler.LeftClick(1378, 717, withSleep: true);
            _mouseHandler.LeftClick(1407, 511, withSleep: true);
            Thread.Sleep(6500);
            _mouseHandler.LeftClick(1258, 755, withSleep: true);
            _mouseHandler.LeftClick(975, 465, withSleep: true);
            Thread.Sleep(2000);

            // soldier 10 and 11
            _mouseHandler.LeftClick(1298, 750, withSleep: true);
            _mouseHandler.LeftClick(1208, 784, withSleep: true);
            Thread.Sleep(6000);
            _mouseHandler.LeftClick(1340, 753, withSleep: true);
            _mouseHandler.LeftClick(1057, 593, withSleep: true);
            Thread.Sleep(2000);

            // soldier 12
            _mouseHandler.LeftClick(1381, 750, withSleep: true);
            _mouseHandler.LeftClick(629, 783, withSleep:true);
            Thread.Sleep(6000);

            // refill med
            _mouseHandler.LeftClick(745, 579, withSleep: true);
            Thread.Sleep(15500);
        }
    }
}