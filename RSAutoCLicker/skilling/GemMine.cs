namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class GemMine : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        public GemMine(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
        }

        public void Do()
        {
            var p = _mouseHandler.CursorPos();
            var s = 4_400;

            // click gems
            _mouseHandler.LeftClick(652, 643, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(757, 583, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(768, 643, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(592, 593, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(706, 473, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(701, 470, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(647, 415, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(877, 408, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(820, 409, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(991, 296, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(987, 464, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(941, 522, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(1218, 579, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(942, 579, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(941, 531, true, true);
            Thread.Sleep(s);

            _mouseHandler.LeftClick(877, 518, true, true);
            Thread.Sleep(s);

            // bank
            _mouseHandler.LeftClick(652, 996, true, true);
            Thread.Sleep(3600);

            _mouseHandler.LeftClick(791, 554, true, true);
            Thread.Sleep(600);

            _keyboardHandler.Send(KeyboardHandler.ScanCodeShort.ESCAPE);
            Thread.Sleep(600);
        }
    }
}