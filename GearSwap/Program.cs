﻿using RsAutoClicker;
using System.Runtime.InteropServices;

namespace KeyPressListener
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        static void Main(string[] args)
        {
            var inventoryHelper = new InventoryHelper();
            var mp = new MouseHandler();
            var paused = false;
            var p = mp.CursorPos();

            while (true)
            {
                var gearSwapX = 1072;
                var gearSwapY = 502;
                
                if(GetAsyncKeyState(0x6A) != 0)
                {
                    paused = true;
                }

                if(GetAsyncKeyState(0x6D) != 0)
                {
                    paused = false;
                }

                if (GetAsyncKeyState(0x52) != 0 && !paused) // 0x52 is the virtual key code for the R key
                {
                    inventoryHelper.GearSwap(gearSwapX, gearSwapY);
                }

                if (GetAsyncKeyState(0x46) != 0 && !paused) // 0x52 is the virtual key code for the F key
                {
                   inventoryHelper.GearSwap(gearSwapX + 90, gearSwapY);
                }

                // mage pray
                if (GetAsyncKeyState(0x51) != 0 && !paused) // the virtual key code for the Q key
                {
                   // inventoryHelper.PraySwap(1128, 788, "mage");
                }


                // range pray
                if (GetAsyncKeyState(0x57) != 0 && !paused) // the virtual key code for the W key
                {
                    //inventoryHelper.PraySwap(1128, 788, "range");
                }

                // melee pray
                if (GetAsyncKeyState(0x45) != 0 && !paused) // the virtual key code for the E key
                {
                   // inventoryHelper.PraySwap(1128, 788, "melee");
                }

            }
        }
    }
}