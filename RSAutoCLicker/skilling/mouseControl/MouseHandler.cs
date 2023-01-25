using RSAutoCLicker;
using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    /// This class handles the windows32 API calls and implements SmoothLeftClick and SmoothRightClick 
    /// which perform moving the mouse to a pixel coordinate of the screen and clicking in that spot
    /// </summary>
    public class MouseHandler : IMouseHandler
    {
        public POINT CursorPos()
        {
            GetCursorPos(out var point);
            return point;
        }

        public void LeftClick(int x, int y, bool isFast = true, bool withSleep = false, bool isVeryFast = false)
        {
            var point = new POINT
            {
                X = x,
                Y = y
            };

            MoveMouse(point, isFast, isVeryFast);
            LeftMouseClick(point.X, point.Y, withSleep);
        }

        public void InstantLeftClick(int xpos, int ypos, bool withSleep = false, bool noClick = false)
        {
            LeftMouseClick(xpos, ypos, withSleep, noClick);
        }

        public void RightClick(int x, int y, bool isFast = false, bool withSleep = false)
        {
            var point = new POINT
            {
                X = x,
                Y = y
            };

            MoveMouse(point, isFast);
            RightMouseClick(point.X, point.Y, withSleep);
        }

        /// <summary>
        /// In order to simulate "smooth" mouse movements, we need to Move the mouse across the screen over delay
        /// </summary>
        private static void MoveMouse(POINT dest, bool isFast = false, bool isVeryFast = false)
        {
            var sleepTime = 1; // 1MS, but CPU cycle times means this is closer to an 8 ms sleep time.
            var increments = isFast ? 12 : 6; // how many pixels we want to move left/right
            if (isVeryFast)
            {
                increments = 24;
            }

            int distanceToMoveX, distanceToMoveY;

            bool isComplete = false;

            while (!isComplete)
            {
                Thread.Sleep(sleepTime);

                GetCursorPos(out var newPoint);

                // recalc if the mouse has moved by me
                CalcDistanceToMove(newPoint, dest, out distanceToMoveX, out distanceToMoveY);

                //if the distance to move is negative, we are going left or down
                if (distanceToMoveX > 0)
                {
                    newPoint.X += increments;
                    distanceToMoveX -= increments;
                }

                if (distanceToMoveX < 0)
                {
                    newPoint.X -= increments;
                    distanceToMoveX += increments;
                }

                if (distanceToMoveY > 0)
                {
                    newPoint.Y += increments;
                    distanceToMoveY -= increments;
                }

                if (distanceToMoveY < 0)
                {
                    newPoint.Y -= increments;
                    distanceToMoveY += increments;
                }

                SetCursorPos(newPoint.X, newPoint.Y);

                var isXComplete = distanceToMoveX > 0 - increments && distanceToMoveX < increments;
                var isYComplete = distanceToMoveY > 0 - increments && distanceToMoveY < increments;
                if (isXComplete && isYComplete)
                {
                    isComplete = true;
                }
            }

            static void CalcDistanceToMove(POINT start, POINT dest, out int distanceToMoveX, out int distanceToMoveY)
            {
                distanceToMoveX = dest.X - start.X;
                distanceToMoveY = dest.Y - start.Y;
            }
        }
        
        #region Windows API Calls 

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        // todo, I think these are correct?
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos, bool withSleep = false, bool noClick = false)
        {
            SetCursorPos(xpos, ypos);
            if (withSleep)
            {
                Thread.Sleep(600);
            }
            if (!noClick)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
            }
        }

        public static void RightMouseClick(int xpos, int ypos, bool withSleep = false)
        {
            SetCursorPos(xpos, ypos);
            if (withSleep)
            {
                Thread.Sleep(1000);
            }
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
        }
               

        #endregion
    }
}