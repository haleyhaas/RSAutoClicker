﻿using RSAutoCLicker;

namespace RsAutoClicker
{
    public interface IMouseHandler
    {
        POINT CursorPos();
        void LeftClick(int x, int y, bool isFast = true, bool withSleep = false);
        void RightClick(int x, int y, bool isFast = true, bool withSleep = false);
    }
}