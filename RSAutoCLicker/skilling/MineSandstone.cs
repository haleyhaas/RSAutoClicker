namespace RsAutoClicker
{
    /// <summary>
    /// Do mining
    /// </summary>
    public class  MineSandstone: IScripter
    {
        private readonly IMouseHandler _mouseHandler;

        public MineSandstone(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(MineSandstone)}");
            var p = _mouseHandler.CursorPos();

            for (var i = 0; i < 7; i++)
            {
                // ore 1
                _mouseHandler.LeftClick(906, 615, true, withSleep: true);
                Thread.Sleep(5420);

                // ore 2
                _mouseHandler.LeftClick(779, 566, true, withSleep: true);
                Thread.Sleep(3420);

                // ore 3
                _mouseHandler.LeftClick(734, 523, true, withSleep: true);
                Thread.Sleep(3250);

                // ore 3
                _mouseHandler.LeftClick(787, 489, true, withSleep: true);
                Thread.Sleep(5250);
            }
            // deposit
            _mouseHandler.LeftClick(61, 786, true);
            Thread.Sleep(8000);

            // return
            _mouseHandler.LeftClick(1265, 380, true, withSleep: true);
            Thread.Sleep(9000);
        }
    }
}