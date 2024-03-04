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
            _mouseHandler.LeftClick(1247, 372, isVeryFast: true);
            Thread.Sleep(150);

            if (_keyboardHandler.CheckPause())
            {
                return;
            }

            if (_counter > 120)
            {
                Thread.Sleep(1000);
                // open bags
                _mouseHandler.LeftClick(1478, 712, true, true);
                _counter = 0;
            }

            if (_stopwatch.ElapsedMilliseconds > 900000)
            {
                // attack
                _mouseHandler.LeftClick(372, 697, true, true);
                _stopwatch.Restart();
            }

            _counter++;
        }
    }
}