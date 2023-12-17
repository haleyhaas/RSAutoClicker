namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Construction : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public Construction(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Construction)}");

            var p = _mouseHandler.CursorPos();
            
            // teleport to house
            _mouseHandler.LeftClick(1316, 773, true, true);
            Thread.Sleep(4500);

            // click settings
            _mouseHandler.LeftClick(1338, 938, true, true);

            // click house settings
            _mouseHandler.LeftClick(1335, 847, true, true);
            Thread.Sleep(500);

            // building mode
            _mouseHandler.LeftClick(1368, 730, true, true);
            Thread.Sleep(1800);

            // move to table
            _mouseHandler.LeftClick(1017, 483, true, true);
            Thread.Sleep(2500);
                       

            for (var i = 0; i < 7; i++)
            {
                // right click build
                _mouseHandler.RightClick(974, 555, true, true);
                Thread.Sleep(250);
                // left click build
                _mouseHandler.LeftClick(966, 610, true, true);
                Thread.Sleep(1000);

                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.KEY_3);
                Thread.Sleep(1600);

                // right click build
                _mouseHandler.RightClick(974, 555, true, true);
                Thread.Sleep(250);
                // left click build
                _mouseHandler.LeftClick(968, 625, true, true);
                Thread.Sleep(1800);

                // confirm
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.KEY_1);
            }

            Thread.Sleep(1000);

            // inventory
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);
            
            // teleport to fishing guild
            _mouseHandler.LeftClick(1335, 714, true, true);
            Thread.Sleep(2800);

            // spell book
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F3);

            // bank
            _mouseHandler.LeftClick(647, 263, true, true);
            Thread.Sleep(7200);

            // withdraw
            _mouseHandler.LeftClick(999, 396, true, true);
            Thread.Sleep(500);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

        }
    }
}