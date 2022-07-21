namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Hunter : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private bool _doSkill;
        public Hunter(IMouseHandler mouseHandler, bool doSkill = false)
        {
            _doSkill = doSkill;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            if (!_doSkill) return;

            Console.WriteLine($"Doing {nameof(Hunter)}");

            // box trap 1
            _mouseHandler.SmoothLeftClick(1210, 554, true, true);
            Thread.Sleep(8500);

            // box trap 2
            _mouseHandler.SmoothLeftClick(1070, 419, true, true);
            Thread.Sleep(8500);

            // box trap 3
            _mouseHandler.SmoothLeftClick(1215, 289, true, true);
            Thread.Sleep(8500);

            // box trap 4
            _mouseHandler.SmoothLeftClick(1347, 434, true, true);
            Thread.Sleep(8500);
        }
    }
}