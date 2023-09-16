namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class AgilitySeers : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public AgilitySeers(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AgilitySeers)}");
            var p = _mouseHandler.CursorPos();

            // click gap
            _mouseHandler.LeftClick(555, 547, true, true);
            Thread.Sleep(6550);

            // click tightrope
            _mouseHandler.LeftClick(727, 713, true, true);
            Thread.Sleep(8900);

            // click gap
            _mouseHandler.LeftClick(817, 661, true, true);
            Thread.Sleep(4200);

            // click gap
            _mouseHandler.LeftClick(582, 664, true, true);
            Thread.Sleep(5400);

            // click edge
            _mouseHandler.LeftClick(833, 558, true, true);
            Thread.Sleep(4000);

            // click wall reset
            _mouseHandler.LeftClick(1104, 251, true, true);
            Thread.Sleep(18_000);
        }
    }
}