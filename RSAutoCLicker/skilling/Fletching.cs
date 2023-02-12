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

            if (_keyboardHandler.CheckPause ())
            {
                return;
            }

            _mouseHandler.LeftClick(1476, 746);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1476, 786);

        }
    }
}