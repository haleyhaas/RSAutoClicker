namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Cooking : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public Cooking(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            if (_keyboardHandler.CheckPause())
            {
                return;
            }

            Console.WriteLine($"Doing {nameof(Cooking)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(915, 466);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(771, 615);

            // withdraw
            _mouseHandler.LeftClick(749, 578);
            Thread.Sleep(200);

            // close
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(100);

            for (var i = 0; i < 28; i++)
            {
                if (_keyboardHandler.CheckPause())
                {
                    break;
                }
                // cook
                _mouseHandler.LeftClick(1191, 744, isFast: true);

                // make all
                for (var j = 0; j < 36; j++)
                {
                    _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                    Thread.Sleep(1);
                }

                // range
                _mouseHandler.LeftClick(785, 661, isFast: true);
                //Thread.Sleep(300);                
            }
            // make all
            for (var j = 0; j < 36; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }
            Thread.Sleep(600);
        }
    }
}