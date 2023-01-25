namespace RsAutoClicker
{
    /// <summary>
    /// Do runecrafting (Lava runes)
    /// </summary>
    public class RunecraftingLava : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _destroyNeck;
        private int _duelingRing;
        private int _repairPouches;
        private int _drinkStam;

        public RunecraftingLava(IMouseHandler mouseHandler)
        {
            _destroyNeck = 0;
            _duelingRing = 0;
            _repairPouches = 0;
            _drinkStam = 0;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Runecrafting)}");

            // get point to assign to each part of the runecrafting process
            var p = _mouseHandler.CursorPos();

            // bank
            _mouseHandler.LeftClick(1325, 663, isFast: true, withSleep: true);
            Thread.Sleep(3900);

            // inventory managment should never change pixel position
            BankManagement();

            // enter altar
            _mouseHandler.LeftClick(819, 55, isFast: true);
            Thread.Sleep(2400);
            _mouseHandler.LeftClick(798, 62, isFast: true, withSleep: true);

            Thread.Sleep(5000);
            
            if(_repairPouches == 9)
            {
                RepairPouches();               
                _repairPouches = 0;
            }

            // walk to altar
            _mouseHandler.LeftClick(1415, 675, isFast: true);
            Thread.Sleep(500);

            // imbue magic
            _mouseHandler.LeftClick(1427, 1017, isFast: true);
            _mouseHandler.LeftClick(1563, 850, isFast: true, withSleep: true);
            _mouseHandler.LeftClick(1329, 1013, isFast: true);
            Thread.Sleep(200);

            // click altar
            _mouseHandler.LeftClick(1518, 786, isFast: true);
            _mouseHandler.LeftClick(1019, 711, isFast: true, withSleep: true);
            Thread.Sleep(1200);

            // empty pouches
            ClickPouches();
            Thread.Sleep(100);

            // click altar
            _mouseHandler.LeftClick(1518, 786, isFast: true);
            _mouseHandler.LeftClick(894, 596, isFast: true);
            Thread.Sleep(600);

            // empty giant
            ClickPouches();
            Thread.Sleep(100);

            // click altar
            _mouseHandler.LeftClick(1518, 786, isFast: true);
            _mouseHandler.LeftClick(894, 596, isFast: true);

            // crafting guild teleport
            _mouseHandler.LeftClick(1463, 893, isFast: true);
            Thread.Sleep(600);
            _mouseHandler.LeftClick(278, 916, isVeryFast: true);
            Thread.Sleep(1900);

            _duelingRing++;
            _destroyNeck++;
            _repairPouches++;
            _drinkStam++;
        }

        private void BankManagement()
        {
            // deposit
            _mouseHandler.LeftClick(894, 820, isFast: true);
            Thread.Sleep(500);

            // drink stam pot
            if (_drinkStam == 6)
            { 
                // withdraw a stam pot
                _mouseHandler.LeftClick(826, 206, isFast: true);
                Thread.Sleep(300);

                // drink
                _mouseHandler.LeftClick(1519, 752, isFast: true, withSleep: true);

                _drinkStam = 0;
                Thread.Sleep(100);
            }

            // withdraw new ring
            if (_duelingRing == 8)
            {
                // withdraw 1 ring
                _mouseHandler.LeftClick(881, 175, isVeryFast: true, withSleep: true);
                            
                // close bank
                _mouseHandler.LeftClick(939, 60, isFast: true);

                // equip
                _mouseHandler.LeftClick(1518, 747, isFast: true, withSleep: true);

                // open bank
                _mouseHandler.LeftClick(870, 502, isFast: true, withSleep: true);
                Thread.Sleep(1000);

                _duelingRing = 0;
            }

            // destroy neck
            if(_destroyNeck == 5)
            {
                // withdraw 1 and close bank
                _mouseHandler.LeftClick(872, 208, isVeryFast: true);
                _mouseHandler.LeftClick(939, 60, isFast: true);

                // inventory destroy
                _mouseHandler.LeftClick(1518, 747, isFast: true, withSleep: true);
                _mouseHandler.LeftClick(334, 930, isFast: true);

                // open bank again
                _mouseHandler.LeftClick(870, 502, isFast: true, withSleep: true);
                Thread.Sleep(1000);

                _destroyNeck = 0;
            }

            // withdraw essence
            _mouseHandler.LeftClick(879, 138, isVeryFast: true);
            Thread.Sleep(200);

            // fill pouches
            ClickPouches();

            // withdraw essence
            _mouseHandler.LeftClick(879, 138, isVeryFast: true);
            Thread.Sleep(200);

            // fill giant
            ClickPouches();

            // withdraw essence
            _mouseHandler.LeftClick(879, 138, isVeryFast: true);
            Thread.Sleep(200);

            // close bank
            _mouseHandler.LeftClick(939, 60, isFast: true);

            // duel arena
            _mouseHandler.LeftClick(1363, 1010, isFast: true);
            _mouseHandler.LeftClick(1590, 903, isFast: true, withSleep: true);
            Thread.Sleep(2800);
        }

        private void RepairPouches()
        {
            // spellbook
            _mouseHandler.LeftClick(1424, 1014, isFast: true);
            Thread.Sleep(250);

            // npc contact
            _mouseHandler.LeftClick(1611, 755, isFast: true);
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

        private void ClickPouches()
        {
            Thread.Sleep(100);
            _mouseHandler.LeftClick(1477, 756, isVeryFast: true);
            Thread.Sleep(50);
            _mouseHandler.LeftClick(1477, 786, isVeryFast: true);
            Thread.Sleep(50);
            _mouseHandler.LeftClick(1477, 826, isVeryFast: true);
            Thread.Sleep(50);
            _mouseHandler.LeftClick(1477, 866, isVeryFast: true);
            Thread.Sleep(50);
        }
    }
}