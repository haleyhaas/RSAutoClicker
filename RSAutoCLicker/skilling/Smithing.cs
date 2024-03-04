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

            // deposit
            _mouseHandler.LeftClick(1523, 750);
            Thread.Sleep(500);

            // withdraw
            _mouseHandler.LeftClick(638, 204);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(687, 278); // gold bars
            Thread.Sleep(100);

            // anvil/furance
            _mouseHandler.LeftClick(1403, 308, true, true);
            Thread.Sleep(5500);

            // make all
            for (var j = 0; j < 100; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }
            Thread.Sleep(24_000);

            // bank
            _mouseHandler.LeftClick(272, 794, true, true);
            Thread.Sleep(5500);           

        }
    }
}