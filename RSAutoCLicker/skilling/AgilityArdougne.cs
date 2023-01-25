
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
            _mouseHandler.LeftClick(822, 262, true, true);
            Thread.Sleep(5_300);

            // click gap
            _mouseHandler.LeftClick(380, 105, true, true);
            Thread.Sleep(9_050);

            // click plank
            _mouseHandler.LeftClick(511, 530, true, true);
            Thread.Sleep(7_300);

            // check count to click marks of grace
            if (_count > 30)
            {
                _mouseHandler.LeftClick(693, 400, true, true);
                Thread.Sleep(4_000);
                _count = 0;
            }

            // jump gap
            _mouseHandler.LeftClick(562, 522, true, true);
            Thread.Sleep(4_500);

            // jump gap
            _mouseHandler.LeftClick(818, 620, true, true);
            Thread.Sleep(4_700);

            // balance thing
            _mouseHandler.LeftClick(1063, 690, true, true);
            Thread.Sleep(7_600);

            // if I didn't fall, we can finish the course
            _mouseHandler.LeftClick(711, 428, true, true);
            Thread.Sleep(12_000);

            _count++;
        }
    }
}
