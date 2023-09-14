using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Thieving : IScripter
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly InventoryHelper _inventoryHelper;
        private readonly Stopwatch _stopwatch;
        private int _counter;
        public Thieving(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _inventoryHelper = new InventoryHelper();
            _stopwatch = Stopwatch.StartNew();
            _counter = 0;
        }

        public void Do()
        {
            if (_keyboardHandler.CheckPause())
            {
                return;
            }

            var p = _mouseHandler.CursorPos();

            // ardy knights
            // pickpocket
            _mouseHandler.LeftClick(970, 440, isVeryFast: true);
            Thread.Sleep(150);

            if (_keyboardHandler.CheckPause())
            {
                return;
            }

            if (_counter > 120)
            {
                // open bags
                _mouseHandler.LeftClick(1413, 676, true, true);
                _counter = 0;
            }

            if (_stopwatch.ElapsedMilliseconds > 900000)
            {
                //Thread.Sleep(6000);

                // attack
                //_mouseHandler.LeftClick(582, 629, true, true);
                _stopwatch.Restart();

                //EatFood();
            }

            _counter++;
        }

        private void EatFood()
        {
            _inventoryHelper.InventoryClear();
            //// click bank
            //_mouseHandler.LeftClick(1205, 172, true, true);
            //Thread.Sleep(1000);
            //
            //// withdraw food
            //_mouseHandler.LeftClick(1044, 436, true, true);
            //Thread.Sleep(300);
            //_keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            //
            //// eat the food
            //_mouseHandler.LeftClick(1474, 604, true, true);
            //Thread.Sleep(300);
            //
            //// return to pickpocket spot
            //_mouseHandler.LeftClick(1211, 503, true, true);

        }
    }
}