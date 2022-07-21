﻿namespace RsAutoClicker
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
                var bottomRightSlotX = 1205;
                var bottomRightSlotY = 694;

                var moveCounter = 0;
                var yCounter = 0;
                for (var i = 0; i < 27; i++)
                {
                    _mouseHandler.SmoothLeftClick(bottomRightSlotX, bottomRightSlotY);
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
}