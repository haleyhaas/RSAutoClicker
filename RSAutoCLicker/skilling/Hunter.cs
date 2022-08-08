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
            var s = 13_500;
            // box trap 1
            _mouseHandler.LeftClick(897, 539, true, true);
            Thread.Sleep(s);

            // box trap 2
            _mouseHandler.LeftClick(691, 391, true, true);
            Thread.Sleep(s);

            // box trap 3
            _mouseHandler.LeftClick(949, 295, true, true);
            Thread.Sleep(s);

            // box trap 4
            _mouseHandler.LeftClick(765, 275, true, true);
            Thread.Sleep(s);

            // box trap 5
            _mouseHandler.LeftClick(1038, 360, true, true);
            Thread.Sleep(s);
        }
    }
}