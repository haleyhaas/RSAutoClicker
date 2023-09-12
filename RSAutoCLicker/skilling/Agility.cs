namespace RsAutoClicker
{
    /// <summary>
    /// Seers Village
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

            // click wall
            _mouseHandler.LeftClick(810, 561, true, true);
            Thread.Sleep(4300);

            // click gap
            _mouseHandler.LeftClick(566, 397, true, true);
            Thread.Sleep(4850);

            // click tightrope
            _mouseHandler.LeftClick(810, 761, true, true);
            Thread.Sleep(8000);

            // click gap
            _mouseHandler.LeftClick(938, 711, true, true);
            Thread.Sleep(3200);

            // click gap
            _mouseHandler.LeftClick(646, 668, true, true);
            Thread.Sleep(4000);

            // click edge
            _mouseHandler.LeftClick(986, 535, true, true);
            Thread.Sleep(2000);

            // click wall reset
            _mouseHandler.LeftClick(1526, 754, true, true);
            Thread.Sleep(16_00);
        }
    }
}