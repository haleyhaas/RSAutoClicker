﻿namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class Herblore : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public Herblore(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Herblore)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(956, 480, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1021, 767, withSleep: true);
            Thread.Sleep(800);

            // withdraw
            _mouseHandler.LeftClick(810, 535, withSleep: true);
            Thread.Sleep(200);

            // withdraw 2
            _mouseHandler.LeftClick(860, 535, withSleep: true);
            Thread.Sleep(200);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1256, 790, withSleep: true);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1256, 820, withSleep: true);
            Thread.Sleep(800);

            // make all
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            // sleep
            //Thread.Sleep(9_000); // unfinished pots
            Thread.Sleep(17_500); // making finished pots
        }
    }
}