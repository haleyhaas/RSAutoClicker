namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Agility3 : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Agility3(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Agility2)}");
            var p = _mouseHandler.CursorPos();

            // tree
            _mouseHandler.LeftClick(717, 391, true, true);
            Thread.Sleep(6600);

            // gap
            _mouseHandler.LeftClick(817, 366, true, true);
            Thread.Sleep(4500);

            // gap
            _mouseHandler.LeftClick(665, 535, true, true);
            Thread.Sleep(4200);

            // gap
            _mouseHandler.LeftClick(640, 672, true, true);
            Thread.Sleep(4600);

            // gap
            _mouseHandler.LeftClick(792, 732, true, true);
            Thread.Sleep(4400);

            // pole vault
            _mouseHandler.LeftClick(875, 609, true, true);
            Thread.Sleep(12600);

            // gap
            _mouseHandler.LeftClick(1229, 526, true, true);
            Thread.Sleep(7000);

            // gap
            _mouseHandler.LeftClick(817, 333, true, true);
            Thread.Sleep(4500);
        }
    }
}