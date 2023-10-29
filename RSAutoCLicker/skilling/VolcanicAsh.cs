namespace RsAutoClicker
{
    /// <summary>
    /// 
    /// </summary>
    public class VolcanicAsh : IScripter
    {
        private readonly IMouseHandler _mouseHandler;

        public VolcanicAsh(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(VolcanicAsh)}");
            var p = _mouseHandler.CursorPos();

            // ash 1
            _mouseHandler.LeftClick(1117, 791,withSleep: true);
            Thread.Sleep(10_000);

            // ash 2
            _mouseHandler.LeftClick(1120, 524, withSleep: true);
            Thread.Sleep(10_000);

            // ash 3
            _mouseHandler.LeftClick(1101, 823, withSleep: true);
            Thread.Sleep(10_000);

            // ash 4
            _mouseHandler.LeftClick(518, 246, withSleep: true);
            Thread.Sleep(20_000);

        }
    }
}