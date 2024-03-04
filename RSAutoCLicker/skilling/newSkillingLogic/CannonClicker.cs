using RSAutoCLicker;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class CannonClicker : Scripter
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private readonly IMouseHandler _mouseHandler;
        private readonly KeyboardHandler _keyboardHandler;
        private readonly InventoryHelper _inventoryHelper;
        private readonly Stopwatch _stopwatch;
        private readonly Stopwatch _stopwatch2;
        private POINT _position;
        private int _counter;
        private int _potionPosX;
        private int _potionPosY;
        private bool _isPaused;

        public CannonClicker(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _keyboardHandler = new KeyboardHandler();
            _inventoryHelper = new InventoryHelper();
            _position = _mouseHandler.CursorPos();
            _counter = 0;
            _potionPosX = 0;
            _potionPosY = 0;
            _stopwatch = new Stopwatch();
            _stopwatch2 = new Stopwatch();
            _stopwatch.Start(); 
            _stopwatch2.Start();
            _actions = new List<IAction>
            {
                new AEvent(() => _mouseHandler.LeftClick(_position.X, _position.Y), 400)
            };
        }

        public override void Do()
        {
            var p = _mouseHandler.CursorPos();

             _isPaused = _keyboardHandler.CheckPause();

            if(_isPaused )
            {
                _position = _mouseHandler.CursorPos();
                return;
            }

            base.Do();                       
            
            if(_stopwatch.ElapsedMilliseconds > 12_000)
            {
                _inventoryHelper.InventoryClear();
                _stopwatch.Restart();
            }

            if(_stopwatch2.ElapsedMilliseconds > 900000)
            {
                _mouseHandler.LeftClick(430, 764);
                _stopwatch2.Restart();
            }

            _counter++;
        }

        private void UseFood(int x, int y)
        {
            var inc = 4;
            if (_counter > 0 && _counter % inc == 0)
            {
                _mouseHandler.LeftClick(x + (_potionPosX * 40), y + (_potionPosY * 40));
                Thread.Sleep(1000);

                _potionPosX++;

                if (_potionPosX > 3)
                {
                    _potionPosX = 0;
                    _counter = 0;
                    _potionPosY++;

                }
            }
        }

        private void UsePrayerPots(int x, int y)
        {
            var inc = 5;

            if (_counter > 0 && _counter % inc == 0)
            {
                _mouseHandler.LeftClick(x + (_potionPosX * 40), y + (_potionPosY * 40));
                Thread.Sleep(1000);

                var positional = _counter / inc;
                if (positional > 3)
                {
                    _potionPosX++;
                    _counter = 0;
                }

                if (_potionPosX > 3)
                {
                    _potionPosX = 0;
                    _potionPosY++;

                }
            }
        }
    }
}