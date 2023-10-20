namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class SuperheatItem : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public SuperheatItem(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(SuperheatItem)}");

            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(940, 843);
            Thread.Sleep(600);

            // deposit
            _mouseHandler.LeftClick(1256, 714);
            Thread.Sleep(300);            

            // withdraw
            _mouseHandler.LeftClick(1003, 358);
            Thread.Sleep(300);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(300);

            for (var i = 0; i < 27; i++)
            {
                // superheat
                _mouseHandler.LeftClick(1250, 810);
                Thread.Sleep(300);

                // item
                _mouseHandler.LeftClick(1383, 892);
                Thread.Sleep(1200);
            }
        }
    }
}