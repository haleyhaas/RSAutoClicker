
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
            _mouseHandler.LeftClick(817, 326, true, true);
            Thread.Sleep(5_300);

            // click gap
            _mouseHandler.LeftClick(723, 178, true, true);
            Thread.Sleep(9_050);

            // click plank
            _mouseHandler.LeftClick(665, 342, true, true);
            Thread.Sleep(7_300);

            // check count to click marks of grace
            if (_count > 20)
            {
                _mouseHandler.LeftClick(745, 339, true, true);
                Thread.Sleep(4_000);
                _count = 0;
            }

            // jump gap
            _mouseHandler.LeftClick(677, 345, true, true);
            Thread.Sleep(4_500);

            // jump gap
            _mouseHandler.LeftClick(732, 425, true, true);
            Thread.Sleep(4_700);

            // balance thing
            _mouseHandler.LeftClick(783, 501, true, true);
            Thread.Sleep(7_600);

            // if I fell, we want to reset our pos
            //_mouseHandler.LeftClick(0, 0, true, true);
            //Thread.Sleep(4_000);

            // if I didn't fall, we can finish the course
            _mouseHandler.LeftClick(741, 349, true, true);
            Thread.Sleep(12_000);

            _count++;
        }
    }
}
