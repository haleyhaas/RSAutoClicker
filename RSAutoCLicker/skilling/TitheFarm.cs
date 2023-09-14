namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class TitheFarm : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public TitheFarm(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(TitheFarm)}");

            var p = _mouseHandler.CursorPos();

            PlantSeeds();

            // reset spot
            _mouseHandler.LeftClick(1045, 589);
            Thread.Sleep(1_800); 


            for(var i = 0; i < 3; i++)
            {
                // each water session takes 24 seconds
                WaterPlants();

                // reset spot
                _mouseHandler.LeftClick(1045, 589);
                Thread.Sleep(30_000);
            }

            Thread.Sleep(30_000);

            // harvest plants
            WaterPlants();

            // reset spot
            _mouseHandler.LeftClick(1045, 589);
            Thread.Sleep(1_800); 

            GetWater();
        }

        private void PlantSeeds()
        {
            var s = 2400;

            // 1
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(984, 656);
            Thread.Sleep(s); 

            // 2
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(804, 655);
            Thread.Sleep(s); 

            // 3
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(758, 641);
            Thread.Sleep(s); 

            // 4
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(749, 654);
            Thread.Sleep(s); 

            // 5
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(929, 377);
            Thread.Sleep(s); 

            // 6
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(1064, 467);
            Thread.Sleep(s); 

            // 7
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(1212, 435);
            Thread.Sleep(s); 

            // 8
            _mouseHandler.LeftClick(1415, 672);
            _mouseHandler.LeftClick(1194, 440);
            Thread.Sleep(s); 
        }

        private void WaterPlants()
        {
            var s = 3_000;
            // 1
            _mouseHandler.LeftClick(984, 656);
            Thread.Sleep(s); 

            // 2
            _mouseHandler.LeftClick(804, 655);
            Thread.Sleep(s); 

            // 3
            _mouseHandler.LeftClick(758, 641);
            Thread.Sleep(s); 

            // 4
            _mouseHandler.LeftClick(749, 654);
            Thread.Sleep(s); 

            // 5
            _mouseHandler.LeftClick(929, 377);
            Thread.Sleep(s); 

            // 6
            _mouseHandler.LeftClick(1064, 467);
            Thread.Sleep(s); 

            // 7
            _mouseHandler.LeftClick(1212, 435);
            Thread.Sleep(s); 

            // 8
            _mouseHandler.LeftClick(1194, 440);
            Thread.Sleep(s); 
        }
    
        private void GetWater()
        {
            // get more water
            _mouseHandler.LeftClick(421, 493);
            Thread.Sleep(5_000);
            _mouseHandler.LeftClick(1459, 680);
            _mouseHandler.LeftClick(800, 303);

            Thread.Sleep(5_500);

            // return to starting point
            _mouseHandler.LeftClick(1144, 707);
            Thread.Sleep(5_000);
            _mouseHandler.LeftClick(1556, 617);

        }
    }
}