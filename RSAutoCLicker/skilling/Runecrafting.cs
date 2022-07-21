namespace RsAutoClicker
{
    /// <summary>
    /// Do runecrafting (Lava runes)
    /// </summary>
    public class Runecrafting : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private bool _doSkill;
        private int _count;
        private int _lastRepair;
        public Runecrafting(IMouseHandler mouseHandler, bool doSkill = false)
        {
            _doSkill = doSkill;
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            if (!_doSkill) return;

            Console.WriteLine($"Doing {nameof(Runecrafting)}");

            var point = _mouseHandler.GetCursorPosition();

            // bank
            _mouseHandler.SmoothLeftClick(756, 326, isFast: true, withSleep: true);
            Thread.Sleep(3500);

            // deposit
            _mouseHandler.SmoothLeftClick(974, 513, isFast: true);
            Thread.Sleep(1000);

            if (_count > 0 && _count == 6)
            {
                // wtihdraw stam pot
                _mouseHandler.SmoothLeftClick(609, 295, true, true);

                // drink
                _mouseHandler.SmoothLeftClick(975, 517, true, true);
            }

            if (_count == 8)
            {
                // withdraw 1
                _mouseHandler.SmoothLeftClick(516, 576, isFast: true);

                // withdraw ring
                _mouseHandler.SmoothLeftClick(659, 288, true, true);

                // withdraw neck
                _mouseHandler.SmoothLeftClick(704, 250, true, true);

                //withdraw all
                _mouseHandler.SmoothLeftClick(612, 578, isFast: true);

                // close bank
                _mouseHandler.SmoothLeftClick(768, 68, isFast: true);

                // equip ring
                _mouseHandler.SmoothLeftClick(980, 515, isFast: true);

                // destroy necklace and confirm
                _mouseHandler.SmoothLeftClick(1016, 511, isFast: true);
                _mouseHandler.SmoothLeftClick(351, 658, isFast: true);

                // open bank
                _mouseHandler.SmoothLeftClick(668, 405, isFast: true, withSleep: true);
                Thread.Sleep(800);
                _count = 0;
            }

            // withdraw essence
            _mouseHandler.SmoothLeftClick(706, 141, isFast: true);
            Thread.Sleep(200);

            if (_count > 0)
            {
                // fill pouches
                Thread.Sleep(150);
                _mouseHandler.SmoothLeftClick(892, 515, isFast: true);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(892, 553);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(892, 591);

                // withdraw essences
                _mouseHandler.SmoothLeftClick(706, 141, isFast: true);
            }

            // close bank
            _mouseHandler.SmoothLeftClick(768, 68, isFast: true);

            // teleport spell, dueling ring teleport
            _mouseHandler.SmoothLeftClick(698, 740, isFast: true);
            _mouseHandler.SmoothRightClick(1013, 668);
            Thread.Sleep(100);
            _mouseHandler.SmoothLeftClick(996, 689);
            Thread.Sleep(2200);

            // altar
            _mouseHandler.SmoothLeftClick(223, 336, isFast: true);
            Thread.Sleep(2550);
            _mouseHandler.SmoothLeftClick(220, 348, isFast: true);
            Thread.Sleep(5200);
            if (_lastRepair == 20)
            {
                // magic spell book, NPC commune dark wizard
                _mouseHandler.SmoothLeftClick(760, 743, isFast: true);
                _mouseHandler.SmoothLeftClick(874, 532, isFast: true);
                Thread.Sleep(500);
                _mouseHandler.SmoothLeftClick(532, 256, isFast: true);
                Thread.Sleep(4500);

                // talk to dark mage to repair
                _mouseHandler.SmoothLeftClick(322, 708);
                Thread.Sleep(500);

                // repair please
                _mouseHandler.SmoothLeftClick(384, 672);
                Thread.Sleep(1000);
                _mouseHandler.SmoothLeftClick(237, 709);
                Thread.Sleep(1000);
                _mouseHandler.SmoothLeftClick(237, 709);

                // inventory
                _mouseHandler.SmoothLeftClick(666, 737, isFast: true);

                _lastRepair = 0;
            }

            // magic imbue
            _mouseHandler.SmoothLeftClick(760, 743, isFast: true);
            _mouseHandler.SmoothLeftClick(959, 638, withSleep: true, isFast: true);

            // inventory
            _mouseHandler.SmoothLeftClick(665, 743, isFast: true);

            // click earth rune on alt
            _mouseHandler.SmoothLeftClick(936, 514, isFast: true);
            _mouseHandler.SmoothLeftClick(838, 214, isFast: true, withSleep: true);
            Thread.Sleep(4200);

            // empty pouch
            _mouseHandler.SmoothLeftClick(891, 516);
            Thread.Sleep(100);
            _mouseHandler.SmoothLeftClick(891, 553);
            Thread.Sleep(100);
            _mouseHandler.SmoothLeftClick(891, 591);
            Thread.Sleep(150);

            if (_count > 0)
            {
                // click earth rune, altar again
                _mouseHandler.SmoothLeftClick(936, 514, isFast: true);
                Thread.Sleep(100);
                _mouseHandler.SmoothLeftClick(685, 387, isFast: true);
                Thread.Sleep(200);
            }

            // crafting cape
            _mouseHandler.SmoothLeftClick(893, 624, isFast: true);
            Thread.Sleep(2300);

            _count++;
            _lastRepair++;
        }
    }
}