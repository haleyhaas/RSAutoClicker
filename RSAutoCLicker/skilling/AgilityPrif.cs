
namespace RsAutoClicker
{
    public class AgilityPrif : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public AgilityPrif(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(AgilityPrif)}");

            var p = _mouseHandler.CursorPos();

            // click wall
            _mouseHandler.LeftClick(1509, 460, true, true);
            Thread.Sleep(6800);

            // tightrope
            _mouseHandler.LeftClick(947, 732, true, true);
            Thread.Sleep(14_000);

            // chimney
            _mouseHandler.LeftClick(874, 431, true, true);
            Thread.Sleep(4700);

            // roof edge
            _mouseHandler.LeftClick(809, 334, true, true);
            Thread.Sleep(4400);

            // dark hole
            _mouseHandler.LeftClick(811, 472, true, true);
            Thread.Sleep(4600);

            // ladder
            _mouseHandler.LeftClick(869, 333, true, true);
            Thread.Sleep(2700);

            // rope bridge
            _mouseHandler.LeftClick(570, 679, true, true);
            Thread.Sleep(9300);

            // tight rope
            _mouseHandler.LeftClick(649, 536, true, true);
            Thread.Sleep(6800);

            // rope bridge
            _mouseHandler.LeftClick(766, 422, true, true);
            Thread.Sleep(9100);

            // tight rope
            _mouseHandler.LeftClick(678, 382, true, true);
            Thread.Sleep(8300);

            // tight rope
            _mouseHandler.LeftClick(994, 412, true, true);
            Thread.Sleep(7000);

            // dark hole
            _mouseHandler.LeftClick(717, 206, true, true);
            Thread.Sleep(7500);
        }
    }
}
