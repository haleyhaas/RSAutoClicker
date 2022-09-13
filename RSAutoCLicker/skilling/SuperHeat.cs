namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class SuperHeat : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public SuperHeat(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(SuperHeat)}");

            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(942, 305);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(918, 694);

            // withdraw
            _mouseHandler.LeftClick(848, 352);
            Thread.Sleep(200);
            _mouseHandler.LeftClick(897, 352);
            Thread.Sleep(150);

            // close
            _mouseHandler.LeftClick(952, 171);
            Thread.Sleep(800);

            // superheat
            for(var i = 0; i < 5; i++)
            {
                // click superheat
                _mouseHandler.LeftClick(1159, 611);
                Thread.Sleep(500);

                // click bar
                _mouseHandler.LeftClick(1158, 771);
                Thread.Sleep(1600);
            }
        }
    }
}