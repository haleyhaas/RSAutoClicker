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

            _mouseHandler.LeftClick(1086, 246);
            Thread.Sleep(6000);

            if(_stopwatch.ElapsedMilliseconds > 45_000)
            {
                _inventoryHelper.InventoryClear();
                _stopwatch.Reset();
                _stopwatch.Start();
            }

            Thread.Sleep(1600);            
        }
    }
}