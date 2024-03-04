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

            for (var i = 0; i < 6; i++)
            {
                // ore 1
                _mouseHandler.LeftClick(913, 600, true, withSleep: true);
                Thread.Sleep(5420);

                // ore 2
                _mouseHandler.LeftClick(782, 575, true, withSleep: true);
                Thread.Sleep(3420);

                // ore 3
                _mouseHandler.LeftClick(733, 544, true, withSleep: true);
                Thread.Sleep(3250);

                // ore 4
                _mouseHandler.LeftClick(775, 490, true, withSleep: true);
                Thread.Sleep(5250);
            }
            // deposit
            _mouseHandler.LeftClick(96, 848, true);
            Thread.Sleep(8000);

            // return
            _mouseHandler.LeftClick(1213, 345, true, withSleep: true);
            Thread.Sleep(8300);
        }
    }
}