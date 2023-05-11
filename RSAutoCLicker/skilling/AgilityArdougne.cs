namespace RsAutoClicker
{
    public interface IAction
    {
        void Execute(IMouseHandler mouseHandler);
        int GetDelay();
    }

    public class AgilityArdougne : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IAction[] _actions;
        private int _count;

        public AgilityArdougne(IMouseHandler mouseHandler)
        {
            _count = 0;
            _mouseHandler = mouseHandler;

            _actions = new IAction[]
            {
                new ActionWithDelay(() => _mouseHandler.LeftClick(822, 262, true, true), 5_300),
                new ActionWithDelay(() => _mouseHandler.LeftClick(723, 178, true, true), 9_050),
                new ActionWithDelay(() => _mouseHandler.LeftClick(665, 342, true, true), 7_300),
                new ActionWithDelay(() => {
                    if (_count > 30) { 
                        _mouseHandler.LeftClick(745, 339, true, true); Thread.Sleep(4_000); 
                    } 
                }, 0),
                new ActionWithDelay(() => _mouseHandler.LeftClick(677, 345, true, true), 4_500),
                new ActionWithDelay(() => _mouseHandler.LeftClick(732, 425, true, true), 4_700),
                new ActionWithDelay(() => _mouseHandler.LeftClick(783, 501, true, true), 7_600),
                new ActionWithDelay(() => _mouseHandler.LeftClick(741, 349, true, true), 12_000)
            };
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AgilityArdougne)} - {_count}");

            foreach (var action in _actions)
            {
                action.Execute(_mouseHandler);
                Thread.Sleep(action.GetDelay());
            }

            _count++;
        }

        private class ActionWithDelay : IAction
        {
            private readonly Action _action;
            private readonly int _delay;

            public ActionWithDelay(Action action, int delay)
            {
                _action = action;
                _delay = delay;
            }

            public void Execute(IMouseHandler mouseHandler)
            {
                _action();
            }

            public int GetDelay()
            {
                return _delay;
            }
        }
    }
}
