namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class PlankMake : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IInventoryHelper _inventoryHelper;
        private readonly KeyboardHandler _keyboardHandler;
        private int _counter = 3;

        public PlankMake(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _inventoryHelper = new InventoryHelper();
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(824, 332, true, true);
            Thread.Sleep(400);

            // deposit
            _mouseHandler.LeftClick(1477, 788, true, true);
            Thread.Sleep(400);
                       
            // withdraw logs
            _mouseHandler.LeftClick(827, 389, true, true);
            Thread.Sleep(400);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(400);

            DoPlankMake();
        }

        public void DoPlankMake()
        {
            var axisBagSlotMove = 38;

            // bottom right most slot
            var bottomRightSlotX = 1602;
            var bottomRightSlotY = 968;

            var moveCounter = 0;
            var yCounter = 0;
            for (var i = 0; i < 26; i++)
            {
                _mouseHandler.LeftClick(1607, 885, isFast: true);
                Thread.Sleep(300);

                _mouseHandler.LeftClick(bottomRightSlotX, bottomRightSlotY, isFast: true);
                Thread.Sleep(1600);
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
}