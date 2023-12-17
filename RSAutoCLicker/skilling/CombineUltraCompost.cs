namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class CombineUltraCompost : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public CombineUltraCompost(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CombineUltraCompost)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(953, 346, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(1255, 714, withSleep: true);
            Thread.Sleep(800);

            // withdraw compost
            _mouseHandler.LeftClick(957, 393);
            Thread.Sleep(200);
            
            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

            // use 1
            _mouseHandler.LeftClick(1257, 677);
            Thread.Sleep(200);

            // use 2
            _mouseHandler.LeftClick(1299, 677);
            Thread.Sleep(800);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.SPACE);

            Thread.Sleep(32_000);
        }
    }
}