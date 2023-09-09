using RSAutoCLicker;
using System.Diagnostics.Metrics;

namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class CannonClicker : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly POINT _position;
        private int _counter;
        private int _potionPosX;
        private int _potionPosY;

        public CannonClicker(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _position = _mouseHandler.CursorPos();
            _counter = 0;
            _potionPosX = 0;
            _potionPosY = 0;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(CannonClicker)}");

            var p = _mouseHandler.CursorPos();

            _mouseHandler.LeftClick(_position.X, _position.Y);
                        
            //UseFood(1239, 745);
            UsePrayerPots(1236, 745);
            Thread.Sleep(12_000);
            _counter++;

        }

        private void UseFood(int x, int y)
        {
            var inc = 5;
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
            var inc = 6;

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