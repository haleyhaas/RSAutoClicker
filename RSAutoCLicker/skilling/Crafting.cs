namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Crafting : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Crafting(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Crafting)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(874, 386);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(918, 694);

            // withdraw
            _mouseHandler.LeftClick(896, 332);
            Thread.Sleep(200);

            // close
            _mouseHandler.LeftClick(957, 167);
            Thread.Sleep(800);

            // click items
            _mouseHandler.LeftClick(1072, 677);
            Thread.Sleep(700);
            _mouseHandler.LeftClick(1062, 699);
            Thread.Sleep(800);

            // make all
            _mouseHandler.LeftClick(622, 808);
            Thread.Sleep(16_000);
        }
    }
}