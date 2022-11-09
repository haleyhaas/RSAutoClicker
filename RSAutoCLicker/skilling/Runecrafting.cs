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
            _count = 0;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Runecrafting)}");

            // get point to assign to each part of the runecrafting process
            var p = _mouseHandler.CursorPos();
           // _mouseHandler.LeftClick(832, 385, isFast: true);

            // bank
            _mouseHandler.LeftClick(1558, 471, isFast: true, withSleep: true);
            Thread.Sleep(3900);

            if (_count == 9)
            {
                // withdraw pot
                _mouseHandler.LeftClick(875, 248, isFast: true);
                Thread.Sleep(800);

                // drink
                _mouseHandler.LeftClick(1562, 753, isFast: true);
            }

            // deposit
            _mouseHandler.LeftClick(898, 825, isFast: true);
            Thread.Sleep(500);                       
                        
            // withdraw essence
            _mouseHandler.LeftClick(880, 212, isFast: true);
            Thread.Sleep(200);

            // fill pouches
            ClickPouches();            

            // withdraw essence
            _mouseHandler.LeftClick(880, 212, isFast: true);
            Thread.Sleep(200);

            // fill giant
            ClickPouches();

            // withdraw essence
            _mouseHandler.LeftClick(880, 212, isFast: true);
            Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(939, 60, isFast: true);

            // teleport
            _mouseHandler.LeftClick(1474, 746, isFast: true, withSleep: true);
            Thread.Sleep(3000);

            // enter altar
            _mouseHandler.LeftClick(800, 385, isFast: true);
            Thread.Sleep(3000);

            if(_count == 9)
            {
                RepairPouches();               
                _count = 0;
            }

            // click altar
            _mouseHandler.LeftClick(265, 377, isFast: true);
            Thread.Sleep(3000);

            // empty pouches
            ClickPouches();

            // click altar
            _mouseHandler.LeftClick(615, 456, isFast: true);

            // empty giant
            ClickPouches();

            // click altar
            _mouseHandler.LeftClick(615, 456, isFast: true);

            // edgeville teleport
            _mouseHandler.LeftClick(1362, 1013, isFast: true, withSleep: true);
            _mouseHandler.LeftClick(1536, 783, isFast: true, withSleep: true);
            _mouseHandler.LeftClick(1329, 1012, isFast: true, withSleep: true);
            Thread.Sleep(1300);

            _count++;
        }

        private void RepairPouches()
        {
            // spellbook
            _mouseHandler.LeftClick(1424, 1014, isFast: true);
            Thread.Sleep(250);

            // npc contact
            _mouseHandler.LeftClick(1516, 755, isFast: true);
            Thread.Sleep(4000);

            // continue...
            _mouseHandler.LeftClick(297, 974, isFast: true);
            Thread.Sleep(1200);

            // repair pls
            _mouseHandler.LeftClick(278, 928, isFast: true);
            Thread.Sleep(1200);

            // continue dialog...
            _mouseHandler.LeftClick(223, 980, isFast: true);
            Thread.Sleep(1200);

            //equipment
            _mouseHandler.LeftClick(1329, 1011, isFast: true);
            Thread.Sleep(100);
        }

        private void ClickPouches()
        {
            _mouseHandler.LeftClick(1475, 784, isFast: true);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1475, 823, isFast: true);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1475, 861, isFast: true);
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1475, 894, isFast: true);
        }
    }
}