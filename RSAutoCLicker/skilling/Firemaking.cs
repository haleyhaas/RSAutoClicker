using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Firemaking : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _counter;
        public Firemaking(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _counter = 0;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Firemaking)}");
            Thread.Sleep(3000);
            var p = _mouseHandler.CursorPos();

            // bank
            if (_counter % 2 == 0)
            {
                _mouseHandler.LeftClick(920, 461, true, true);
            }
            else
            {
                _mouseHandler.LeftClick(976, 480, true, true);
            }
            Thread.Sleep(1500);

            // withdraw
            _mouseHandler.LeftClick(1017, 387);
            Thread.Sleep(500);

            // run to square
            if (_counter % 2 == 0)
            {
                _mouseHandler.LeftClick(1122, 129, true, true);
            }
            else
            {
                _mouseHandler.LeftClick(1151, 137, true, true);
            }
            Thread.Sleep(9_000);

            // do firemaking
            var p1 = new POINT { X = 1408, Y = 736 }; // logs
            var p2 = new POINT { X = 1281, Y = 520 }; // tinderbox

            DoFiremaking(p1, p2);
            Thread.Sleep(500);
            
            _counter++;
        }

        private void DoFiremaking(POINT bottomRight, POINT topLeft)
        {
            var axisBagSlotMove = 37;
            var moveCounter = 0;
            var yCounter = 0;

            var startX = bottomRight.X;
            var startY = bottomRight.Y;
            for (var i = 0; i < 27; i++)
            {
                _mouseHandler.LeftClick(startX, startY);
                Thread.Sleep(500 + (i*5));
                _mouseHandler.LeftClick(topLeft.X, topLeft.Y);
                Thread.Sleep(2575);

                if (moveCounter <= 2)
                {
                    startX -= axisBagSlotMove;
                    moveCounter++;
                }
                else
                {
                    startX += axisBagSlotMove * 3;
                    startY -= axisBagSlotMove;
                    moveCounter = 0;
                    yCounter++;
                }
            }
        }
    }
}