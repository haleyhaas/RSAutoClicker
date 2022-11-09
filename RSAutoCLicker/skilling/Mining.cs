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
            _mouseHandler.LeftClick(964, 581, true);
            Thread.Sleep(1600);

            // ore 2
            _mouseHandler.LeftClick(786, 913, true);
            Thread.Sleep(1600);

            // ore 3
            _mouseHandler.LeftClick(496, 629, true);
            Thread.Sleep(1200);

            // clear the 3 inventory slots from ore
            _mouseHandler.LeftClick(1483, 750, true);
            _mouseHandler.LeftClick(1523, 750, true);
            _mouseHandler.LeftClick(1563, 750, true);
            _mouseHandler.LeftClick(1603, 750, true);
        }
    }
}