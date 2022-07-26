﻿namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class CannonClicker : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public CannonClicker(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CannonClicker)}");
            var p = _mouseHandler.CursorPos();
            _mouseHandler.LeftClick(771, 446);
            Thread.Sleep(18_000);
        }
    }
}