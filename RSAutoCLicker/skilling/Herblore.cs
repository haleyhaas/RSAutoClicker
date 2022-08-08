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
            _mouseHandler.LeftClick(591, 449, true, true);
            Thread.Sleep(1500);

            // deposit
            _mouseHandler.LeftClick(838, 591);

            // withdraw 1
            _mouseHandler.LeftClick(486, 178);

            // withdraw 2
            _mouseHandler.LeftClick(529, 176);

            // close bank
            _mouseHandler.LeftClick(879, 100);

            // use 1
            _mouseHandler.LeftClick(1233, 610);

            // use 2
            _mouseHandler.LeftClick(1226, 648);
            Thread.Sleep(350);

            // make all
            _mouseHandler.LeftClick(421, 707);

            // sleep
            Thread.Sleep(8_000);
        }
    }
}