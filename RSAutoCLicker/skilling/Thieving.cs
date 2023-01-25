namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Thieving : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Thieving(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Thieving)}");
            var p = _mouseHandler.CursorPos();
            var s = 1350;

            // click
            _mouseHandler.LeftClick(850, 428, true, true);
            Thread.Sleep(s);

            // drop
            _mouseHandler.LeftClick(1149, 517, true, true);
            Thread.Sleep(200);
        }
    }
}