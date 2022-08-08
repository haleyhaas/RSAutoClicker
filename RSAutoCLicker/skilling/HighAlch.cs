namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class HighAlch : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public HighAlch(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(HighAlch)}");

            var p = _mouseHandler.CursorPos();

            _mouseHandler.LeftClick(1506, 541);
            Thread.Sleep(1800);            
        }
    }
}