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

            // box trap 1
            _mouseHandler.LeftClick(1210, 554, true, true);
            Thread.Sleep(8500);

            // box trap 2
            _mouseHandler.LeftClick(1070, 419, true, true);
            Thread.Sleep(8500);

            // box trap 3
            _mouseHandler.LeftClick(1215, 289, true, true);
            Thread.Sleep(8500);

            // box trap 4
            _mouseHandler.LeftClick(1347, 434, true, true);
            Thread.Sleep(8500);
        }
    }
}