using System.Diagnostics;

namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Woodcutting : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly Stopwatch _stopwatch;
        public Woodcutting(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _stopwatch = Stopwatch.StartNew();
            _inventoryHelper = new InventoryHelper();
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Woodcutting)}");

            var p = _mouseHandler.CursorPos();

            _mouseHandler.LeftClick(812, 328, withSleep: true);

            if(_stopwatch.ElapsedMilliseconds > 30_000)
            {
                // fletch
                _mouseHandler.LeftClick(1517, 750, withSleep: true);
                Thread.Sleep(250);
                _mouseHandler.LeftClick(1557, 750, withSleep: true);
                Thread.Sleep(1200);

                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(12_000);
                _stopwatch.Restart();
            }

            Thread.Sleep(6000);

        }
    }
}