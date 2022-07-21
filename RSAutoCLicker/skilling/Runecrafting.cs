namespace RsAutoClicker
{
    /// <summary>
    /// Do runecrafting (Lava runes)
    /// </summary>
    public class Runecrafting : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _count;
        private int _lastRepair;
        public Runecrafting(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Runecrafting)}");

            // get point to assign to each part of the runecrafting process
            //var point = _mouseHandler.GetCursorPosition();

            // bank
            _mouseHandler.SmoothLeftClick(1167, 290, isFast: true, withSleep: true);
            Thread.Sleep(3500);

            // deposit
            _mouseHandler.SmoothLeftClick(1754, 454, isFast: true);
            Thread.Sleep(1000);

            if (_count > 0 && _count == 6)
            {
                // wtihdraw stam pot
                _mouseHandler.SmoothLeftClick(1386, 311, true, true);

                // drink
                _mouseHandler.SmoothLeftClick(1754, 454, true, true);
            }
            _count = 8;
            if (_count == 8)
            {
                // withdraw neck
                _mouseHandler.SmoothLeftClick(1383, 268, true, true);

                // close bank
                _mouseHandler.SmoothLeftClick(1445, 85, isFast: true);
                Thread.Sleep(500);

                // destroy necklace and confirm
                _mouseHandler.SmoothLeftClick(1754, 454, isFast: true);
                Thread.Sleep(1500);
                _mouseHandler.SmoothLeftClick(1200, 669, isFast: true);

                // open bank
                _mouseHandler.SmoothLeftClick(1325, 387, isFast: true, withSleep: true);
                Thread.Sleep(800);
                _count = 0;
            }

            // withdraw essence
            _mouseHandler.SmoothLeftClick(1381, 157, isFast: true);
            Thread.Sleep(200);

            if (_count > 0)
            {
                // fill pouches
                Thread.Sleep(150);
                _mouseHandler.SmoothLeftClick(1625, 460, isFast: true);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(1663, 460);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(1701, 460);              

                // withdraw essences
                _mouseHandler.SmoothLeftClick(1384, 158, isFast: true);
            }

            // close bank
            _mouseHandler.SmoothLeftClick(1447, 86, isFast: true);

            // teleport spell with ring
            _mouseHandler.SmoothLeftClick(1628, 496, isFast: true);
            Thread.Sleep(2600);

            // altar
            _mouseHandler.SmoothLeftClick(1202, 117, isFast: true);
            Thread.Sleep(2550);
            _mouseHandler.SmoothLeftClick(1354, 158, isFast: true, true);
            Thread.Sleep(4800);
            if (_lastRepair == 20)
            {
                // magic spell book, NPC commune dark wizard
                _mouseHandler.SmoothLeftClick(1781, 753, isFast: true);
                _mouseHandler.SmoothLeftClick(1612, 472, isFast: true);
                Thread.Sleep(500);
                _mouseHandler.SmoothLeftClick(1211, 272, isFast: true);
                Thread.Sleep(4500);

                // talk to dark mage to repair
                _mouseHandler.SmoothLeftClick(1172, 723);
                Thread.Sleep(500);

                // repair please
                _mouseHandler.SmoothLeftClick(1176, 691);
                Thread.Sleep(1000);
                _mouseHandler.SmoothLeftClick(1080, 723);
                Thread.Sleep(1000);
                _mouseHandler.SmoothLeftClick(1080, 723);

                // inventory
                _mouseHandler.SmoothLeftClick(666, 737, isFast: true);

                _lastRepair = 0;
            }

            // magic imbue
            _mouseHandler.SmoothLeftClick(1781, 753, isFast: true);
            _mouseHandler.SmoothLeftClick(1695, 580, withSleep: true, isFast: true);

            // inventory
            _mouseHandler.SmoothLeftClick(1684, 758, isFast: true);

            // click earth rune on alt
            _mouseHandler.SmoothLeftClick(1671, 490, isFast: true);
            _mouseHandler.SmoothLeftClick(1058, 99, isFast: true, withSleep: true);
            Thread.Sleep(4200);
            
            if (_count > 0)
            {
                // empty pouch
                _mouseHandler.SmoothLeftClick(1625, 460, isFast: true);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(1663, 460);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(1701, 460);
                Thread.Sleep(150);

                // click earth rune, altar again
                _mouseHandler.SmoothLeftClick(1674, 490, isFast: true);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(1233, 342, isFast: true);
                Thread.Sleep(200);
            }

            // crafting cape
            _mouseHandler.SmoothLeftClick(1629, 527, isFast: true);
            Thread.Sleep(2300);

            _count++;
            _lastRepair++;
        }
    }
}