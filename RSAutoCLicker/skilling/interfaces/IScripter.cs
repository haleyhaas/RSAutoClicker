namespace RsAutoClicker
{
    public interface IScripter
    {
        void Do();
    }

    public interface IAction
    {
        int Delay { get; }

        void Execute(IMouseHandler mouseHandler);
    }

    public class AEvent : IAction
    {
        private readonly Action _action;
        protected readonly int _delay;

        public int Delay { get => _delay; }

        public AEvent(Action action, int delay)
        {
            _action = action;
            _delay = delay;
        }

        public void Execute(IMouseHandler mouseHandler)
        {
            _action();
        }
    }

    public class Scripter : IScripter
    {        
        private readonly IMouseHandler _mouseHandler = new MouseHandler();
        public List<IAction>? _actions;

        public virtual void Do()
        {
            Console.WriteLine($"Doing {GetType().Name}");
            foreach (var action in _actions ?? new List<IAction>())
            {
                action.Execute(_mouseHandler);
                Thread.Sleep(action.Delay);
            }
        }
    }
}