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
            _mouseHandler.LeftClick(1473, 845, true, true);
            Thread.Sleep(4500);
            
            // click settings
            _mouseHandler.LeftClick(1558, 1012, isFast: true, withSleep: true);
            
            // click house settings
            _mouseHandler.LeftClick(1565, 923, true, true);
            Thread.Sleep(500);
            
            // building mode
            _mouseHandler.LeftClick(1593, 804, true, true);
            Thread.Sleep(1800);
            
            // move to table
            _mouseHandler.LeftClick(1068, 480, true, true);
            Thread.Sleep(2500);
                      

            for (var i = 0; i < 8; i++)
            {
                // right click build
                _mouseHandler.RightClick(881, 502, true, true);
                Thread.Sleep(250);
                // left click build
                _mouseHandler.LeftClick(886, 558, true, true);
                Thread.Sleep(1000);

                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.KEY_3);
                Thread.Sleep(1600);

                // right click
                _mouseHandler.RightClick(903, 490, true, true);
                Thread.Sleep(250);
                // left click remove
                _mouseHandler.LeftClick(889, 549, true, true);
                Thread.Sleep(1200);

                // confirm
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.KEY_1);
            }

            Thread.Sleep(1000);

            // inventory
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F1);
            
            // teleport to fishing guild
            _mouseHandler.LeftClick(1559, 752, true, true);
            Thread.Sleep(2800);

            // spell book
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.F3);

            // bank
            _mouseHandler.LeftClick(937, 235, true, true);
            Thread.Sleep(7200);

            // withdraw
            _mouseHandler.LeftClick(876, 391, true, true);
            Thread.Sleep(500);

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

        }
    }
}