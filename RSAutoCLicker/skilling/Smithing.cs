namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Smithing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Smithing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Smithing)}");

            var p = _mouseHandler.CursorPos();
            
            // bank
            _mouseHandler.LeftClick(498, 505, true, true);
            Thread.Sleep(4000);

            // deposit
            _mouseHandler.LeftClick(923, 666);
            Thread.Sleep(500);

            // withdraw bars + energy pot
            _mouseHandler.LeftClick(900, 339);
            Thread.Sleep(200);
            _mouseHandler.LeftClick(903, 378);

            // anvil
            _mouseHandler.LeftClick(1208, 465, true, true);
            Thread.Sleep(5000);

            // make all
            _mouseHandler.LeftClick(676, 483);
            Thread.Sleep(14_000);

            // drink pots
            _mouseHandler.LeftClick(1117, 758);            
        }
    }
}