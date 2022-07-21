namespace RsAutoClicker
{
    /// <summary>
    /// Do Hunter (Red chins)
    /// </summary>
    public class Agility : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Agility(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Agility)}");
            // todo
        }
    }
}