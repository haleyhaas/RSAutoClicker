using RSAutoCLicker;
using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class WorldHopper : Scripter
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private int _counter;
        private bool _isPaused;

        public WorldHopper(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _counter = 0;
            
        }

        public override void Do()
        {

            // NOTE THAT THE AVERAGE HOP TIME IS ~10 SECONDS
            var p = _mouseHandler.CursorPos();
            var increment = 25;
            _isPaused = _keyboardHandler.CheckPause();

            if(_isPaused )
            {
                return;
            }

            _mouseHandler.InstantLeftClick(1552, 185 + increment * _counter);
            Thread.Sleep(50);
            _mouseHandler.InstantLeftClick(1552, 185 + increment * _counter);

            _counter++;

            if(_counter >= 20)
            {
                _counter = 0;
            }
        }     
    }
}