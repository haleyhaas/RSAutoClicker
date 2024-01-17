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
            _mouseHandler.LeftClick(682, 838, withSleep:true);
            Thread.Sleep(3200);

            // deposit
            _mouseHandler.LeftClick(898, 822);
            Thread.Sleep(200);

            // withdraw
            _mouseHandler.LeftClick(592, 131);
            Thread.Sleep(200);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(1000);

            // cook
            _mouseHandler.LeftClick(930, 282, isFast: true, withSleep: true);
            Thread.Sleep(3200);

            // make all
            for (var j = 0; j < 70; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }
            Thread.Sleep(66_000);
        }
    }
}