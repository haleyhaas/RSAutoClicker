
namespace RsAutoClicker
{
    public class AgilityArdougne : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _count;
        public AgilityArdougne(IMouseHandler mouseHandler)
        {
            _count = 0;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AgilityArdougne)} - {_count}");
            var p = _mouseHandler.CursorPos();

            // start
            _mouseHandler.LeftClick(1044, 489, true, true);
            Thread.Sleep(5_000);

            // click gap
            _mouseHandler.LeftClick(798, 49, true, true);
            Thread.Sleep(8_750);

            // click plank
            _mouseHandler.LeftClick(637, 519, true, true);
            Thread.Sleep(7_000);

            // check count to click marks of grace
            if (_count > 20)
            {
                _mouseHandler.LeftClick(858, 522, true, true);
                Thread.Sleep(1_000);
                _count = 0;
            }

            // jump gap
            _mouseHandler.LeftClick(673, 551, true, true);
            Thread.Sleep(4_200);

            // jump gap
            _mouseHandler.LeftClick(811, 783, true, true);
            Thread.Sleep(4_400);

            // balance thing
            _mouseHandler.LeftClick(947, 942, true, true);
            Thread.Sleep(7_400);

            // finish the course
            _mouseHandler.LeftClick(851, 571, true, true);
            Thread.Sleep(11_600);

            _count++;
        }
    }
}
