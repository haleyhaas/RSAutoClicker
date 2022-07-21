namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Agility : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Agility(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Agility)}");

            // click tree
            _mouseHandler.SmoothLeftClick(1277, 171, true, true);
            Thread.Sleep(2300);

            // click wall
            _mouseHandler.SmoothLeftClick(810, 561, true, true);
            Thread.Sleep(4300);

            // click gap
            _mouseHandler.SmoothLeftClick(566, 397, true, true);
            Thread.Sleep(4850);

            // click tightrope
            _mouseHandler.SmoothLeftClick(810, 761, true, true);
            Thread.Sleep(8000);

            // click gap
            _mouseHandler.SmoothLeftClick(938, 711, true, true);
            Thread.Sleep(3200);

            // click gap
            _mouseHandler.SmoothLeftClick(646, 668, true, true);
            Thread.Sleep(4000);

            // click edge
            _mouseHandler.SmoothLeftClick(986, 535, true, true);
            Thread.Sleep(2000);

            // teleport reset
            _mouseHandler.SmoothLeftClick(1526, 754, true, true);
            Thread.Sleep(2000);
        }
    }
}