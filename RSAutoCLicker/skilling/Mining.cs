namespace RsAutoClicker
{
    /// <summary>
    /// Do mining (Iron ore)
    /// </summary>
    public class Mining : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private bool _doSkill;

        public Mining(IMouseHandler mouseHandler, bool doSkill = false)
        {
            _doSkill = doSkill;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            if (!_doSkill) return;

            Console.WriteLine($"Doing {nameof(Mining)}");

            // ore 1
            _mouseHandler.SmoothLeftClick(1290, 471, true);
            Thread.Sleep(2000);

            // ore 2
            _mouseHandler.SmoothLeftClick(1156, 585, true);
            Thread.Sleep(2000);

            // ore 3
            _mouseHandler.SmoothLeftClick(1054, 434, true);
            Thread.Sleep(2000);

            // clear the 3 inventory slots from ore
            _mouseHandler.SmoothLeftClick(1608, 532, true);
            _mouseHandler.SmoothLeftClick(1648, 532, true);
            _mouseHandler.SmoothLeftClick(1688, 532, true);
        }
    }
}