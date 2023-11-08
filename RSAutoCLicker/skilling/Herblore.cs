using RSAutoCLicker;

namespace RsAutoClicker
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
            var unfinished = false;

            var harralander = new POINT();
            harralander.X = unfinished ? 718 : 718+90;
            harralander.Y = 359;

            var ranarr = new POINT();
            ranarr.X = harralander.X;
            ranarr.Y = harralander.Y + 40;

            var vial = new POINT();
            vial.X = unfinished ? 761 : 761 + 100;
            vial.Y = unfinished ? 286 : ranarr.Y; // change here

            // bank
            _mouseHandler.LeftClick(947, 429, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1021, 767, withSleep: true);
            Thread.Sleep(800);

            // withdraw herb
            _mouseHandler.LeftClick(ranarr.X, ranarr.Y, withSleep: true); // change here
            Thread.Sleep(200);

            // withdraw vial
            _mouseHandler.LeftClick(vial.X, vial.Y, withSleep: true);
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
            if (unfinished)
            {
                Thread.Sleep(9_000); // unfinished pots
            }
            else
            {
                Thread.Sleep(17_500); // making finished pots
            }
        }
    }
}