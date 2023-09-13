namespace RsAutoClicker
{ 
    public class BloodEssenceCraft : Scripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _count;

        public BloodEssenceCraft(IMouseHandler mouseHandler)
        {
            _count = 0;
            _mouseHandler = mouseHandler;

            var p = _mouseHandler.CursorPos();

            _actions = new List<IAction>
            {
                new AEvent(() => _mouseHandler.LeftClick(822, 262, true, true), 5_300),  // start
                new AEvent(() => _mouseHandler.LeftClick(723, 178, true, true), 9_050),  // gap
                new AEvent(() => _mouseHandler.LeftClick(665, 342, true, true), 7_300),  // plank               
                new AEvent(() => _mouseHandler.LeftClick(677, 345, true, true), 4_500),  // gasp
                new AEvent(() => _mouseHandler.LeftClick(732, 425, true, true), 4_700),  // gap
                new AEvent(() => _mouseHandler.LeftClick(783, 501, true, true), 7_600),  // balance
                new AEvent(() => _mouseHandler.LeftClick(741, 349, true, true), 12_000)  // finish
            };
        }  
    }
}
