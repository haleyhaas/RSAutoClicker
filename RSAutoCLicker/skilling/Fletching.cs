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

            _mouseHandler.LeftClick(1287, 661);
            Thread.Sleep(75);
            _mouseHandler.LeftClick(1287, 700);

        }
    }
}