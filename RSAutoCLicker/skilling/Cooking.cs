namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Cooking : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Cooking(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Cooking)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(874, 386);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(918, 694);

            // withdraw
            _mouseHandler.LeftClick(850, 256);
            Thread.Sleep(200);
            _mouseHandler.LeftClick(897, 256);
            Thread.Sleep(150);

            // close
            _mouseHandler.LeftClick(952, 171);
            Thread.Sleep(800);

            // click items
            _mouseHandler.LeftClick(1067, 658);
            Thread.Sleep(700);
            _mouseHandler.LeftClick(1067, 691);
            Thread.Sleep(800);

            // make all
            _mouseHandler.LeftClick(711, 797);
            Thread.Sleep(17_000);
        }
    }
}