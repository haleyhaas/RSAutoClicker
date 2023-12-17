namespace RsAutoClicker
{
    public class InventoryHelper : IInventoryHelper
    {
        private readonly MouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public InventoryHelper()
        {
            _mouseHandler = new MouseHandler();
            _keyboardHandler = new KeyboardHandler();
        }
        public void InventoryClear()
        {
            {
                var axisBagSlotMove = 38;

                // bottom right most slot
                var bottomRightSlotX = 1384;
                var bottomRightSlotY = 891;

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
    
        public void GearSwap(int x, int y, int swapNumber = 6)
        {
            Console.WriteLine("Gear Swap");
            var s = 50;
            var pos = _mouseHandler.CursorPos();
            var xCount = 0;
            var yCount = 0;
            for(var i = 0; i < swapNumber; i++)
            {
                _mouseHandler.InstantLeftClick(x + xCount, y + yCount);
                Thread.Sleep(s);

                if(i % 2 == 0)
                {
                    xCount += 40;
                }
                else if(i % 2 == 1 && i > 0)
                {
                    yCount += 40;
                    xCount -= 40;
                }
            }
           
            _mouseHandler.InstantLeftClick(pos.X, pos.Y, noClick: true);
        }

        public void PraySwap(int bookX, int bookY, string type)
        {
            var pos = _mouseHandler.CursorPos();

            var s = 100;
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F12);
            Thread.Sleep(1);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F2);
            Thread.Sleep(s);
            switch (type)
            {
                case "mage":
                    _mouseHandler.InstantLeftClick(bookX, bookY);
                    break;
                case "range":
                    _mouseHandler.InstantLeftClick(bookX + 40, bookY);
                    break;
                default:
                    _mouseHandler.InstantLeftClick(bookX + 80, bookY);
                    break;
            }
            Thread.Sleep(s);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);

            _mouseHandler.InstantLeftClick(pos.X, pos.Y, noClick: true);
        }
    }
}