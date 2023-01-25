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
            Console.WriteLine($"Doing {nameof(Cooking)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(950, 582);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(829, 596);

            // withdraw
            _mouseHandler.LeftClick(814, 544);
            Thread.Sleep(200);

            // close
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(100);

            for (var i = 0; i < 28; i++)
            {                

                // cook
                _mouseHandler.LeftClick(1212, 721, isFast: true);

                // make all
                for (var j = 0; j < 36; j++)
                {
                    _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                    Thread.Sleep(1);
                }

                // range
                _mouseHandler.LeftClick(767, 676, isFast: true);
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