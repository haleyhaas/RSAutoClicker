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
            var s = 16_000;

            // box trap 1
            _mouseHandler.LeftClick(1177, 529, true, true);
            Thread.Sleep(s);

            // box trap 2
            _mouseHandler.LeftClick(944, 758, true, true);
            Thread.Sleep(s);

            // box trap 3
            _mouseHandler.LeftClick(721, 539, true, true);
            Thread.Sleep(s);

            // box trap 4
            _mouseHandler.LeftClick(935, 315, true, true);
            Thread.Sleep(s);

            // box trap 5
            //_mouseHandler.LeftClick(753, 289, true, true);
            //Thread.Sleep(s);
            //
            //// box trap 5
            //_mouseHandler.LeftClick(1038, 360, true, true);
            //Thread.Sleep(s);
        }
    }
}