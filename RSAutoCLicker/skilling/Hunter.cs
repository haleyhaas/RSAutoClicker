namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Hunter : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Hunter(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Hunter)}");
            var p = _mouseHandler.CursorPos();
            var s = 10_200;

            // box trap 1
            _mouseHandler.LeftClick(902, 447, true, true);
            Thread.Sleep(s);

            // box trap 2
            _mouseHandler.LeftClick(733, 597, true, true);
            Thread.Sleep(s);

            // box trap 3
            _mouseHandler.LeftClick(667, 369, true, true);
            Thread.Sleep(s);

            // box trap 4
            _mouseHandler.LeftClick(659, 519, true, true);
            Thread.Sleep(s);

            // box trap 5
            _mouseHandler.LeftClick(753, 289, true, true);
            Thread.Sleep(s);

            // box trap 5
            _mouseHandler.LeftClick(1038, 360, true, true);
            Thread.Sleep(s);
        }
    }
}