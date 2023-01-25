namespace RsAutoClicker
{
    /// <summary>
    /// Canifis
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
            Console.WriteLine($"Doing {nameof(Agility3)}");
            var p = _mouseHandler.CursorPos();

            // tree
            _mouseHandler.LeftClick(614, 291, true, true);
            Thread.Sleep(6600);

            // gap
            _mouseHandler.LeftClick(671, 213, true, true);
            Thread.Sleep(4500);

            // gap
            _mouseHandler.LeftClick(524, 435, true, true);
            Thread.Sleep(4200);

            // gap
            _mouseHandler.LeftClick(507, 597, true, true);
            Thread.Sleep(4600);

            // gap
            _mouseHandler.LeftClick(688, 662, true, true);
            Thread.Sleep(4400);

            // pole vault
            _mouseHandler.LeftClick(776, 507, true, true);
            Thread.Sleep(7600);

            // gap
            _mouseHandler.LeftClick(1173, 373, true, true);
            Thread.Sleep(7000);

            // gap
            _mouseHandler.LeftClick(681, 192, true, true);
            Thread.Sleep(4500);
        }
    }
}