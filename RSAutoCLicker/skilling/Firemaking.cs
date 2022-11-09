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
            Console.WriteLine($"Doing {nameof(Mining)}");
            Thread.Sleep(3000);
            var p = _mouseHandler.CursorPos();

            // bank
            if (_counter % 2 == 0)
            {
                _mouseHandler.LeftClick(792, 531, true, true);
            }
            else
            {
                _mouseHandler.LeftClick(795, 531, true, true);
            }
            Thread.Sleep(1500);

            // withdraw
            _mouseHandler.LeftClick(871, 279);
            Thread.Sleep(500);

            // close
            _mouseHandler.LeftClick(940, 60);
            Thread.Sleep(500);

            // run to square
            if (_counter % 2 == 0)
            {
                _mouseHandler.LeftClick(1613, 540, true, true);
            }
            else
            {
                _mouseHandler.LeftClick(1611, 483, true, true);
            }
            Thread.Sleep(9_000);

            // do firemaking
            var p1 = new POINT { X = 1605, Y = 968 }; // logs
            var p2 = new POINT { X = 1477, Y = 756 }; // tinderbox

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