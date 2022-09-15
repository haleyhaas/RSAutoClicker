using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Firemaking : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Firemaking(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Firemaking)}");
            var p = _mouseHandler.CursorPos();

            // withdraw
            _mouseHandler.LeftClick(1024, 447);
            Thread.Sleep(3_000);

            // run to square
            _mouseHandler.LeftClick(1134, 268, true, true);
            Thread.Sleep(10_000);

            // do firemaking
            var p1 = new POINT{X = 1324, Y = 757};
            var p2 = new POINT { X = 1190, Y = 545 };

            DoFiremaking(p1, p2);
            Thread.Sleep(4_000);

            // bank
            _mouseHandler.LeftClick(826, 415, true, true);
            Thread.Sleep(4_000);
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
                Thread.Sleep(1000);
                _mouseHandler.LeftClick(topLeft.X, topLeft.Y);
                Thread.Sleep(3075);

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