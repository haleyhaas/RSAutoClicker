namespace RsAutoClicker
{
    /// <summary>
    /// </summary>
    public class CombineCompost : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public CombineCompost(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CombineCompost)}");
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(844, 293, true, true);
            Thread.Sleep(1000);

            // deposit
            _mouseHandler.LeftClick(895, 822, withSleep: true);
            Thread.Sleep(800);

            // withdraw 4 compost pots
            _mouseHandler.LeftClick(875, 281);
            Thread.Sleep(200);

            for (var i = 0; i < 4; i++)
            {
                // withdraw 16 compost
                _mouseHandler.LeftClick(879, 314);
                Thread.Sleep(200);
            }

            // close bank
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);

            for (var i = 0; i < 19; i++)
            {
                // use 1
                _mouseHandler.LeftClick(1602, 753);
                Thread.Sleep(200);

                // use 2
                _mouseHandler.LeftClick(1603, 896);
                Thread.Sleep(200);
            }

        }
    }
}