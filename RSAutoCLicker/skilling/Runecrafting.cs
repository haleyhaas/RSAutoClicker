namespace RsAutoClicker
{
    /// <summary>
    /// Do runecrafting (Lava runes)
    /// </summary>
    public class Runecrafting : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _count;

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
            //_mouseHandler.LeftClick(835, 355, isFast: true);

            // bank
            _mouseHandler.LeftClick(1255, 669, isFast: true, withSleep: true);
            Thread.Sleep(3900);

            // inventory managment should never change pixel position
            BankManagement();

            // enter altar
            _mouseHandler.LeftClick(835, 355, isFast: true);
            Thread.Sleep(3000);

            if(_count == 7)
            {
                RepairPouches();               
                _count = 0;
            }

            // click altar
            _mouseHandler.LeftClick(484, 348, isFast: true);
            Thread.Sleep(3000);

            // empty pouches
            ClickPouches();

            // click altar
            _mouseHandler.LeftClick(692, 450, isFast: true);

            // empty giant
            ClickPouches(true);

            // click altar
            _mouseHandler.LeftClick(738, 464, isFast: true, withSleep: true);

            // crafting guild teleport
            _mouseHandler.LeftClick(1362, 1013, isFast: true);
            _mouseHandler.LeftClick(1497, 790, isFast: true);
            _mouseHandler.LeftClick(1329, 1012, isFast: true);
            Thread.Sleep(1300);

            _count++;
        }

        private void BankManagement()
        {
            // deposit
            _mouseHandler.LeftClick(898, 825, isFast: true);
            Thread.Sleep(500);

            // withdraw essence
            _mouseHandler.LeftClick(880, 206, isVeryFast: true);
            Thread.Sleep(200);

            // fill pouches
            ClickPouches();

            // withdraw essence
            _mouseHandler.LeftClick(880, 212, isVeryFast: true);
            Thread.Sleep(200);

            // fill giant
            ClickPouches(true);

            // withdraw essence
            _mouseHandler.LeftClick(880, 212, isVeryFast: true);
            Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(939, 60, isFast: true);


            // teleport
            _mouseHandler.LeftClick(1474, 746, isFast: true, withSleep: true);
            Thread.Sleep(3000);
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
            _mouseHandler.LeftClick(282, 925, isFast: true);
            Thread.Sleep(1200);

            // continue dialog...
            _mouseHandler.LeftClick(223, 980, isFast: true);
            Thread.Sleep(1200);

            //equipment
            _mouseHandler.LeftClick(1329, 1011, isFast: true);
            Thread.Sleep(100);
        }

        private void ClickPouches(bool fillGiant = false)
        {
            Thread.Sleep(300);
            _mouseHandler.LeftClick(1475, 784, isVeryFast: true);
        }
    }
}