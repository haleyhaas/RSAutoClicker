namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class BlastFurnace : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly WorldHopper _worldHopper;
        private int _counter;
        public BlastFurnace(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _worldHopper = new WorldHopper(_mouseHandler);
            _counter = 0;
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();

            // click blast furnace
            _mouseHandler.LeftClick(613, 89, true, true);
            Thread.Sleep(6_200);

            // click next to bar dispenser
            _mouseHandler.LeftClick(740, 728, true, true);
            Thread.Sleep(6_000);

            // swap gloves
            _mouseHandler.LeftClick(1484, 751, true, true);
            Thread.Sleep(600);

            // withdraw ore
            _mouseHandler.LeftClick(825, 487, withSleep: true);
            Thread.Sleep(1300);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            // click bank
            _mouseHandler.LeftClick(1147, 775, true, true);
            Thread.Sleep(4_500);

            // deposit ore
            _mouseHandler.LeftClick(1486, 787, true, true);
            Thread.Sleep(400);

            if (_counter == 5)
            {
                // withdraw and drink a stam
                _mouseHandler.LeftClick(639, 283, true, true);
                Thread.Sleep(400);
                _mouseHandler.LeftClick(1524, 754, true, true);
                _counter = 0;
            }

            // withdraw gold again
            _mouseHandler.LeftClick(593, 280, true, true);
            Thread.Sleep(400);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);

            // swap gloves
            _mouseHandler.LeftClick(1482, 751, true, true);

            _counter++;
        }
    }
}