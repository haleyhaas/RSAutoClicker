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
        private readonly Stopwatch _stopwatch;
        public Woodcutting(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _stopwatch = Stopwatch.StartNew();
            _inventoryHelper = new InventoryHelper();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Woodcutting)}");

            var p = _mouseHandler.CursorPos();

            _mouseHandler.LeftClick(888, 552, withSleep: true);

            if(_stopwatch.ElapsedMilliseconds > 60_000)
            {
                // bank
                _mouseHandler.LeftClick(1367, 523, withSleep: true);
                Thread.Sleep(5000);
                _mouseHandler.LeftClick(1029, 764, withSleep: true);
                Thread.Sleep(1000);

                // return to tree
                _mouseHandler.LeftClick(503, 559, withSleep: true);
                Thread.Sleep(6000);

                _stopwatch.Restart();
            }

            Thread.Sleep(6000);

        }
    }
}