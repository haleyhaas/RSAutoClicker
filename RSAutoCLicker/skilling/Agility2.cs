namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
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
            _mouseHandler.LeftClick(370, 619, true, true);
            Thread.Sleep(8200);

            // clothes line
            _mouseHandler.LeftClick(650, 535, true, true);
            Thread.Sleep(8650);

            // gap
            _mouseHandler.LeftClick(598, 463, true, true);
            Thread.Sleep(8500);

            // wall
            _mouseHandler.LeftClick(678, 541, true, true);
            Thread.Sleep(11300);

            // gap
            _mouseHandler.LeftClick(854, 672, true, true);
            Thread.Sleep(6500);

            // gap
            _mouseHandler.LeftClick(1272, 527, true, true);
            Thread.Sleep(10200);

            // gap
            _mouseHandler.LeftClick(1237, 444, true, true);
            Thread.Sleep(8500);

            // ledge
            _mouseHandler.LeftClick(837, 358, true, true);
            Thread.Sleep(5500);

            // edge
            _mouseHandler.LeftClick(820, 371, true, true);
            Thread.Sleep(4_500);
        }
    }
}