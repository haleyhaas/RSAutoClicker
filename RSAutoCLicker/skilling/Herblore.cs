namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Herblore : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Herblore(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Herblore)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(1000, 357, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1044, 666);
            Thread.Sleep(800);

            // withdraw 1
            _mouseHandler.LeftClick(976, 520);
            Thread.Sleep(200);

            // withdraw 2
            _mouseHandler.LeftClick(1020, 520);
            Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(1086, 160);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1196, 655);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1196, 686);
            Thread.Sleep(400);

            // make all
            _mouseHandler.LeftClick(830, 786);

            // sleep
            Thread.Sleep(15_600);
        }
    }
}