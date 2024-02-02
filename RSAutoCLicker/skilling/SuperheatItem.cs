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
            _mouseHandler.LeftClick(808, 361);
            Thread.Sleep(600);

            // deposit
            _mouseHandler.LeftClick(1479, 784);
            Thread.Sleep(300);            

            // withdraw
            _mouseHandler.LeftClick(831, 355);
            Thread.Sleep(300);
            _mouseHandler.LeftClick(876, 355);
            Thread.Sleep(300);
            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(300);

            for (var i = 0; i < 9; i++)
            {
                // superheat
                _mouseHandler.LeftClick(1472, 886);
                Thread.Sleep(300);

                // item
                _mouseHandler.LeftClick(1603, 966);
                Thread.Sleep(1200);
            }
        }
    }
}