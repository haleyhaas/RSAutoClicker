namespace RsAutoClicker
{
    /// <summary>
    /// Do mining (Iron ore)
    /// </summary>
    public class Mining : IScripter
    {
        private readonly IMouseHandler _mouseHandler;

        public Mining(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Mining)}");
            var p = _mouseHandler.CursorPos();

            // ore 1
            _mouseHandler.LeftClick(1057, 439, true);
            Thread.Sleep(2000);

            // ore 2
            _mouseHandler.LeftClick(948, 522, true);
            Thread.Sleep(2000);

            // ore 3
            _mouseHandler.LeftClick(847, 429, true);
            Thread.Sleep(2000);

            // clear the 3 inventory slots from ore
            _mouseHandler.LeftClick(1333, 460, true);
            _mouseHandler.LeftClick(1373, 460, true);
            _mouseHandler.LeftClick(1413, 460, true);
        }
    }
}