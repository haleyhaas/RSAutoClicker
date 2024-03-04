﻿using RSAutoCLicker;

namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class SuperglassMake : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public SuperglassMake(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();
            
            // bank
            _mouseHandler.LeftClick(841, 365, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1482, 751, withSleep: true);

            // withdraw seaweed
            _mouseHandler.LeftClick(877, 500, withSleep: true); // change here
            _mouseHandler.LeftClick(877, 500, withSleep: true); // change here
            _mouseHandler.LeftClick(877, 500, withSleep: true); // change here

            // withdraw sand
            _mouseHandler.LeftClick(833, 497, withSleep: true);
            Thread.Sleep(200);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(200);

            // make glass
            _mouseHandler.LeftClick(1547, 848, withSleep: true);
            Thread.Sleep(1300);

        }
    }
}