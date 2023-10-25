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
            _mouseHandler.LeftClick(570, 824);
            Thread.Sleep(2200);

            // deposit
            _mouseHandler.LeftClick(1018, 768);
            Thread.Sleep(200);

            // withdraw
            _mouseHandler.LeftClick(807, 287);
            Thread.Sleep(200);

            // cook
            _mouseHandler.LeftClick(1291, 338, isFast: true);
            Thread.Sleep(2200);

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