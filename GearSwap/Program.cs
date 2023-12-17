using RsAutoClicker;
using RSAutoCLicker;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeyPressListener
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        static void Main(string[] args)
        {
            var inventoryHelper = new InventoryHelper();
            var keyboard = new KeyboardHandler();
            var mouse = new MouseHandler();

            var gearSwapX = 1259;
            var gearSwapY = 677;
            var swapCount = 5;

            while (true)
            {
                var cursorPos = mouse.CursorPos();
                var isPaused = keyboard.CheckPause();

                if (IsKeyPressed(0x52) && !isPaused) // 0x52 is the virtual key code for the R key
                {
                    RunePouches(cursorPos);
                    //inventoryHelper.InventoryClear();
                    //inventoryHelper.GearSwap(gearSwapX, gearSwapY, swapCount);
                }

                if (IsKeyPressed(0x46) && !isPaused) // 0x46 is the virtual key code for the F key
                {
                    inventoryHelper.GearSwap(gearSwapX + 90, gearSwapY, swapCount);
                }

                //if (IsKeyPressed(0x43) && !isPaused) // 0x43 is the virtual key code for the C key
                //{
                //    mouse.InstantLeftClick(1265, 291, withSleep: true);
                //    Thread.Sleep(100);
                //    mouse.InstantLeftClick(cursorPos.X, cursorPos.Y, noClick: true);
                //}

               //if (IsKeyPressed(0x45) && !isPaused) // 0x43 is the virtual key code for the E key
               //{
               //    mouse.InstantLeftClick(gearSwapX + 30, gearSwapY + 195);
               //    Thread.Sleep(100);                    
               //    mouse.InstantLeftClick(cursorPos.X, cursorPos.Y, noClick: true);
               //}
            }
        }

        private static bool IsKeyPressed(int virtualKeyCode)
        {
            return (GetAsyncKeyState(virtualKeyCode) & 0x8000) != 0;
        }

        private static void RunePouches(POINT cursorPos)
        {
            var mouse = new MouseHandler();
            mouse.InstantLeftClick(1250, 675);
            Thread.Sleep(100);
            mouse.InstantLeftClick(1250, 715);
            Thread.Sleep(300);

            mouse.InstantLeftClick(cursorPos.X, cursorPos.Y, withSleep: true);
        }
    }
}
