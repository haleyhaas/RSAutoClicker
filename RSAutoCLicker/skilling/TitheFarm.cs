namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class TitheFarm : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _counter;
        public TitheFarm(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
            _counter = 0;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(TitheFarm)}");

            var p = _mouseHandler.CursorPos();
            void ResetSpot()
            {
                _mouseHandler.LeftClick(826, 590);
            }
            PlantSeeds();

            // reset spot
            ResetSpot();
            Thread.Sleep(1_800); 


            for(var i = 0; i < 3; i++)
            {
                // each water session takes 24 seconds
                WaterPlants();

                // reset spot
                ResetSpot();
                Thread.Sleep(30_000);
            }

            Thread.Sleep(30_000);

            // harvest plants
            WaterPlants();

            // reset spot
            ResetSpot();
            Thread.Sleep(1_800);
            if (_counter > 40)
            {
                GetWater();
                _counter = 0;
            }

            _counter++;
        }

        private void PlantSeeds()
        {
            var p = _mouseHandler.CursorPos();
            var s = 2400;
            void ClickSeed()
            {
                _mouseHandler.LeftClick(1479, 785);
            }
            // 1
            ClickSeed();
            _mouseHandler.LeftClick(879, 632);
            Thread.Sleep(s);

            // 2
            ClickSeed();
            _mouseHandler.LeftClick(723, 648);
            Thread.Sleep(s);

            // 3
            ClickSeed();
            _mouseHandler.LeftClick(625, 656);
            Thread.Sleep(s);

            // 4
            ClickSeed();
            _mouseHandler.LeftClick(615, 654);
            Thread.Sleep(s);

            // 5
            ClickSeed();
            _mouseHandler.LeftClick(757, 387);
            Thread.Sleep(s);

            // 6
            ClickSeed();
            _mouseHandler.LeftClick(907, 425);
            Thread.Sleep(s);

            // 7
            ClickSeed();
            _mouseHandler.LeftClick(1011, 420);
            Thread.Sleep(s);

            // 8
            ClickSeed();
            _mouseHandler.LeftClick(1012, 418);
            Thread.Sleep(s); 
        }

        private void WaterPlants()
        {
            var s = 3_000;

            // 1
            _mouseHandler.LeftClick(879, 632);
            Thread.Sleep(s);

            // 2
            _mouseHandler.LeftClick(723, 648);
            Thread.Sleep(s);

            // 3
            _mouseHandler.LeftClick(625, 656);
            Thread.Sleep(s);

            // 4
            _mouseHandler.LeftClick(615, 654);
            Thread.Sleep(s);

            // 5
            _mouseHandler.LeftClick(757, 387);
            Thread.Sleep(s);

            // 6
            _mouseHandler.LeftClick(907, 425);
            Thread.Sleep(s);

            // 7
            _mouseHandler.LeftClick(1011, 420);
            Thread.Sleep(s);

            // 8
            _mouseHandler.LeftClick(1012, 418);
            Thread.Sleep(s);
        }
    
        private void GetWater()
        {
            // get more water
            _mouseHandler.LeftClick(1477, 751);
            _mouseHandler.LeftClick(175, 334);

            Thread.Sleep(10_500);

            // return to starting point
            _mouseHandler.LeftClick(1496, 677);
            Thread.Sleep(10_500);

        }
    }
}