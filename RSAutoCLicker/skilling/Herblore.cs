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
            var posFromDwarfWeed = 5;

            var unfinishedPot = new POINT();
            unfinishedPot.X =  733;
            unfinishedPot.Y = 572 - (posFromDwarfWeed * 35);

            var secondary = new POINT();
            secondary.X = 688;
            secondary.Y = 567 - (posFromDwarfWeed * 35);

            // bank
            _mouseHandler.LeftClick(827, 398, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(897, 821, withSleep: true);
            Thread.Sleep(800);

            // withdraw secondary
            _mouseHandler.LeftClick(secondary.X, secondary.Y, withSleep: true); // change here
            Thread.Sleep(200);

            // withdraw unfinished pot
            _mouseHandler.LeftClick(unfinishedPot.X, unfinishedPot.Y, withSleep: true);
            Thread.Sleep(200);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1480, 863, withSleep: true);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1480, 897, withSleep: true);
            Thread.Sleep(800);

            // make all
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            // sleep
            Thread.Sleep(17_500); // making finished pots

        }
    }
}