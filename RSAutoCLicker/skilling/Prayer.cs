namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Prayer : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Prayer(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Prayer)}");

            var p = _mouseHandler.CursorPos();

            // click dragon bones
            _mouseHandler.LeftClick(1303, 533);

            // click on Phials
            _mouseHandler.LeftClick(763, 266);
            Thread.Sleep(3500);

            // click swap all
            _mouseHandler.LeftClick(299, 729);
            Thread.Sleep(500);

            // click visit last house
            _mouseHandler.LeftClick(681, 752);
            Thread.Sleep(4300);

            // click bones
            _mouseHandler.LeftClick(1342, 534);

            // click altar
            _mouseHandler.LeftClick(914, 654);
            Thread.Sleep(20_000);

            // click portal
            _mouseHandler.LeftClick(682, 270);
            Thread.Sleep(3300);            
        }
    }
}