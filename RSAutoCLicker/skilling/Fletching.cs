namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Fletching : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Fletching(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Fletching)}");
            var p = _mouseHandler.CursorPos();

            _mouseHandler.LeftClick(1076, 545);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1120, 545);

        }
    }
}