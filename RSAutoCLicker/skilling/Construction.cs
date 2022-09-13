namespace RsAutoClicker
{
    /// <summary>
    ///
    /// </summary>
    public class Construction : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        public Construction(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(Construction)}");

            var p = _mouseHandler.CursorPos();

            // teleport to house
            _mouseHandler.LeftClick(1072, 542, true, true);
            Thread.Sleep(4500);

            // click settings
            _mouseHandler.LeftClick(1161, 840, true, true);

            // click house settings
            _mouseHandler.LeftClick(1160, 715, true, true);
            Thread.Sleep(500);

            // building mode
            _mouseHandler.LeftClick(1190, 595, true, true);
            Thread.Sleep(1800);

            // move to table
            _mouseHandler.LeftClick(865, 638, true, true);
            Thread.Sleep(2500);
                       

            for (var i = 0; i < 4; i++)
            {
                // right click build
                _mouseHandler.RightClick(852, 537, true, true);
                Thread.Sleep(250);
                // left click build
                _mouseHandler.LeftClick(848, 588, true, true);

                // left click build table
                _mouseHandler.LeftClick(776, 395, true, true);
                Thread.Sleep(2000);

                // right click remove
                _mouseHandler.RightClick(852, 537, true, true);
                Thread.Sleep(250);
                // left click remove
                _mouseHandler.LeftClick(848, 588, true, true);
                Thread.Sleep(1200);

                // left click confirm
                _mouseHandler.LeftClick(715, 763, true, true);
                Thread.Sleep(2400);
            }

            // click equipment
            _mouseHandler.LeftClick(1156, 802, true, true);
            
            // left click edgeville
            _mouseHandler.LeftClick(1137, 581, true, true);
            Thread.Sleep(2800);

            // click inventory
            _mouseHandler.LeftClick(1126, 801, true, true);

            // bank
            _mouseHandler.LeftClick(989, 297, true, true);
            Thread.Sleep(3800);

            // withdraw
            _mouseHandler.LeftClick(900, 488, true, true);
            Thread.Sleep(500);

            // close bank
            _mouseHandler.LeftClick(963, 160, true, true);
            Thread.Sleep(500);

        }
    }
}