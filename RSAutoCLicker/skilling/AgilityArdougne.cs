namespace RsAutoClicker
{    
    public class AgilityArdougne : Scripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _count;

        public AgilityArdougne(IMouseHandler mouseHandler)
        {
            _count = 0;
            _mouseHandler = mouseHandler;

            var p = _mouseHandler.CursorPos();

            _actions = new List<IAction>
            {
                new AEvent(() => _mouseHandler.LeftClick(822, 262, true, true), 5_300),  // start
                new AEvent(() => _mouseHandler.LeftClick(723, 178, true, true), 9_050),  // gap
                new AEvent(() => _mouseHandler.LeftClick(665, 342, true, true), 7_300),  // plank
                new AEvent(() => {
                    if (_count > 30) { 
                        _mouseHandler.LeftClick(745, 339, true, true);              // mark of grace
                        Thread.Sleep(4_000); 
                        _count = 0;
                    } 
                }, 0),
                new AEvent(() => _mouseHandler.LeftClick(677, 345, true, true), 4_500),  // gasp
                new AEvent(() => _mouseHandler.LeftClick(732, 425, true, true), 4_700),  // gap
                new AEvent(() => _mouseHandler.LeftClick(783, 501, true, true), 7_600),  // balance
                new AEvent(() => _mouseHandler.LeftClick(741, 349, true, true), 12_000)  // finish
            };
        }

        public override void Do()
        {
            base.Do();
            _count++;
        }

        
    }
}
