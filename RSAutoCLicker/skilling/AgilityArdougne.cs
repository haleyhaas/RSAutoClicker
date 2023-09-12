namespace RsAutoClicker
{
    public interface IAction
    {
        int Delay { get; }

        void Execute(IMouseHandler mouseHandler);        
    }

    public class AgilityArdougne : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly List<IAction> _actions;
        private int _count;

        public AgilityArdougne(IMouseHandler mouseHandler)
        {
            _count = 0;
            _mouseHandler = mouseHandler;

            var p = _mouseHandler.CursorPos();

            _actions = new List<IAction>
            {
                new A(() => _mouseHandler.LeftClick(822, 262, true, true), 5_300),  // start
                new A(() => _mouseHandler.LeftClick(723, 178, true, true), 9_050),  // gap
                new A(() => _mouseHandler.LeftClick(665, 342, true, true), 7_300),  // plank
                new A(() => {
                    if (_count > 30) { 
                        _mouseHandler.LeftClick(745, 339, true, true);              // mark of grace
                        Thread.Sleep(4_000); 
                        _count = 0;
                    } 
                }, 0),
                new A(() => _mouseHandler.LeftClick(677, 345, true, true), 4_500),  // gasp
                new A(() => _mouseHandler.LeftClick(732, 425, true, true), 4_700),  // gap
                new A(() => _mouseHandler.LeftClick(783, 501, true, true), 7_600),  // balance
                new A(() => _mouseHandler.LeftClick(741, 349, true, true), 12_000)  // finish
            };
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AgilityArdougne)} - {_count}");

            foreach (var action in _actions)
            {
                action.Execute(_mouseHandler);
                Thread.Sleep(action.Delay);
            }

            _count++;
        }

        private class A : IAction
        {
            private readonly Action _action;
            protected readonly int _delay;

            public int Delay { get => _delay; }

            public A(Action action, int delay)
            {
                _action = action;
                _delay = delay;
            }

            public void Execute(IMouseHandler mouseHandler)
            {
                _action();
            }
        }
    }
}
