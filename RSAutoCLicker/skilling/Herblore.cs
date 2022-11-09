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
            _mouseHandler.LeftClick(1058, 692);
            Thread.Sleep(800);

            // withdraw 1
            _mouseHandler.LeftClick(990, 550);
            Thread.Sleep(200);

            // withdraw 2
            _mouseHandler.LeftClick(1034, 550);
            Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(1100, 190);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1210, 682);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1210, 712);
            Thread.Sleep(800);

            // make all
            _mouseHandler.LeftClick(851, 807);

            // sleep
            Thread.Sleep(15_600);
        }
    }
}