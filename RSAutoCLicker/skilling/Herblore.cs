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
            _mouseHandler.LeftClick(1027, 443, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1069, 546);
            Thread.Sleep(800);

            // withdraw
            _mouseHandler.LeftClick(631, 300);
            Thread.Sleep(200);

            // withdraw 2
            //_mouseHandler.LeftClick(1034, 550);
            //Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(838, 47);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1072, 510);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1072, 550);
            Thread.Sleep(800);

            // make all
            _mouseHandler.LeftClick(476, 717);

            // sleep
            Thread.Sleep(32_000);
        }
    }
}