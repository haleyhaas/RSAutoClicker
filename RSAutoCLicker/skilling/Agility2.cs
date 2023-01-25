namespace RsAutoClicker
{
    /// <summary>
    /// Falador course
    /// </summary>
    public class Agility2 : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Agility2(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Agility2)}");
            var p = _mouseHandler.CursorPos();

            // rough wall
            _mouseHandler.LeftClick(911, 145, true, true);
            Thread.Sleep(6200);

            // tightrope
            _mouseHandler.LeftClick(830, 372, true, true);
            Thread.Sleep(7050);

            // hand holds
            _mouseHandler.LeftClick(786, 214, true, true);
            Thread.Sleep(9000);

            // gap
            _mouseHandler.LeftClick(636, 351, true, true);
            Thread.Sleep(2500);

            // gap
            _mouseHandler.LeftClick(579, 404, true, true);
            Thread.Sleep(3500);

            // tightrope
            _mouseHandler.LeftClick(484, 402, true, true);
            Thread.Sleep(8400);

            // tightrope
            _mouseHandler.LeftClick(636, 444, true, true);
            Thread.Sleep(5200);

            // gap
            _mouseHandler.LeftClick(623, 449, true, true);
            Thread.Sleep(2500);

            // ledge
            _mouseHandler.LeftClick(621, 520, true, true);
            Thread.Sleep(2500);

            // ledge
            _mouseHandler.LeftClick(632, 514, true, true);
            Thread.Sleep(2200);

            // ledge
            _mouseHandler.LeftClick(694, 637, true, true);
            Thread.Sleep(4000);

            // ledge
            _mouseHandler.LeftClick(858, 406, true, true);
            Thread.Sleep(2500);

            // edge
            _mouseHandler.LeftClick(867, 388, true, true);
            Thread.Sleep(4500);
        }
    }
}