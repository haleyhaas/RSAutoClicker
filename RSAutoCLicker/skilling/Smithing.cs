namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Smithing : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public Smithing(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Smithing)}");

            var p = _mouseHandler.CursorPos();
            
            // bank
            _mouseHandler.LeftClick(1101, 226, true, true);
            Thread.Sleep(3500);

            // deposit
            _mouseHandler.LeftClick(1106, 529);
            Thread.Sleep(500);

            // withdraw bars
            _mouseHandler.LeftClick(750, 392);
            Thread.Sleep(100);

            // anvil
            _mouseHandler.LeftClick(283, 626, true, true);
            Thread.Sleep(2500);

            // make all
            for (var j = 0; j < 100; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }
            Thread.Sleep(25_000);      
        }
    }
}