namespace RsAutoClicker
{
    public class InventoryHelper : IInventoryHelper
    {
        private readonly MouseHandler _mouseHandler;

        public InventoryHelper()
        {
            _mouseHandler = new MouseHandler();
        }
        public void InventoryClear()
        {
            {
                var axisBagSlotMove = 38;

                // bottom right most slot
                var bottomRightSlotX = 1459;
                var bottomRightSlotY = 741;

                var moveCounter = 0;
                var yCounter = 0;
                for (var i = 0; i < 26; i++)
                {
                    _mouseHandler.LeftClick(bottomRightSlotX, bottomRightSlotY);
                    if (moveCounter <= 2)
                    {
                        bottomRightSlotX -= axisBagSlotMove;
                        moveCounter++;
                    }
                    else
                    {
                        bottomRightSlotX += axisBagSlotMove * 3;
                        bottomRightSlotY -= axisBagSlotMove;
                        moveCounter = 0;
                        yCounter++;
                    }
                }
            }
        }
    
        public void GearSwap(int x, int y)
        {
            Console.WriteLine("Gear Swap");

            var pos = _mouseHandler.CursorPos();

            var s = 50;
            _mouseHandler.InstantLeftClick(x, y);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x + 40, y);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x, y + 40);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x + 40, y + 40);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x, y + 80);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x + 40, y + 80);
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(x, y + 120);
            Thread.Sleep(s);
            //_mouseHandler.InstantLeftClick(x + 40, y + 120);
            //Thread.Sleep(s);

            _mouseHandler.InstantLeftClick(pos.X, pos.Y, noClick: true);

        }

        public void PraySwap(int bookX, int bookY, string type)
        {
            var pos = _mouseHandler.CursorPos();

            var s = 100;
            _mouseHandler.InstantLeftClick(bookX, bookY);
            Thread.Sleep(s);
            switch (type)
            {
                case "mage":
                    _mouseHandler.InstantLeftClick(bookX + 110, bookY - 150);
                    break;
                case "range":
                    _mouseHandler.InstantLeftClick(bookX + 150, bookY - 150);
                    break;
                default:
                    _mouseHandler.InstantLeftClick(bookX + 190, bookY - 150);
                    break;
            }
            Thread.Sleep(s);
            _mouseHandler.InstantLeftClick(bookX - 60, bookY);
            Thread.Sleep(s);

            _mouseHandler.InstantLeftClick(pos.X, pos.Y, noClick: true);
        }
    }
}