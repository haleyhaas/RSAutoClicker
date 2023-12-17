namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Fletching : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public Fletching(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Fletching)}");
            var p = _mouseHandler.CursorPos();

            if (_keyboardHandler.CheckPause())
            {
                return;
            }

            _mouseHandler.LeftClick(1252, 673);
            Thread.Sleep(75);
            _mouseHandler.LeftClick(1292, 673);
            Thread.Sleep(1000);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);
            Thread.Sleep(12_000);
        }
    }
}