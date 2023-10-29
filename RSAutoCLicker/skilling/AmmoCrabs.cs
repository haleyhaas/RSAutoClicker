namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class AmmoCrabs : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public AmmoCrabs(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AmmoCrabs)}");
            var p = _mouseHandler.CursorPos();
            var timeBetweenResets = 660000; // 11 mins

            Thread.Sleep(timeBetweenResets);

            // 1st spot
            _mouseHandler.LeftClick(875, 463);
            Thread.Sleep(10_000);
            _mouseHandler.LeftClick(1016, 653);
            Thread.Sleep(timeBetweenResets);

            // 2nd spot
            _mouseHandler.LeftClick(890, 734);
            Thread.Sleep(10_000);
            _mouseHandler.LeftClick(989, 407);
            Thread.Sleep(timeBetweenResets);

            // 3rd spot
            _mouseHandler.LeftClick(566, 649);
            Thread.Sleep(10_000);
            _mouseHandler.LeftClick(1248, 477);
        }
    }
}