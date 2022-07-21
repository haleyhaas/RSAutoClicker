using RSAutoCLicker;

namespace RsAutoClicker
{
    public interface IMouseHandler
    {
        POINT GetCursorPosition();
        void SmoothLeftClick(int x, int y, bool isFast = true, bool withSleep = false);
        void SmoothRightClick(int x, int y, bool isFast = true, bool withSleep = false);
    }
}