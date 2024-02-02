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
            _mouseHandler.LeftClick(1478, 789);
            Thread.Sleep(500);

            // withdraw
            _mouseHandler.LeftClick(877, 570);
            //Thread.Sleep(100);
            //_mouseHandler.LeftClick(1000, 355);
            //Thread.Sleep(100);

            // anvil/furance
            _mouseHandler.LeftClick(1405, 355, true, true);
            Thread.Sleep(5500);

            // make all
            for (var j = 0; j < 100; j++)
            {
                _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
                Thread.Sleep(1);
            }
            Thread.Sleep(11_000);

            // bank
            _mouseHandler.LeftClick(216, 663, true, true);
            Thread.Sleep(5500);           

        }
    }
}