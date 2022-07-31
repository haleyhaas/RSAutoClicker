namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class CannonClicker : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public CannonClicker(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CannonClicker)}");
            var p = _mouseHandler.GetCursorPosition();
            _mouseHandler.LeftClick(-1105, 662);
            Thread.Sleep(25_000);
        }
    }
}