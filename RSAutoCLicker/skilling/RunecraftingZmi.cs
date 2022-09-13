namespace RsAutoClicker
{
    /// <summary>
    /// Do runecrafting (ZMI)
    /// </summary>
    public class RunecraftingZmi : IScripter
    {
        private readonly IMouseHandler _mouseHandler;
        private int _lastRepair;
        public RunecraftingZmi(IMouseHandler mouseHandler)
        {
            _mouseHandler = mouseHandler;
        }

        public void Do()
        {
            Console.WriteLine($"Doing {nameof(RunecraftingZmi)}");

            var point = _mouseHandler.CursorPos();
            
            // hide NPCs
            _mouseHandler.LeftClick(-62, 475);
            
            // teleport and click to square
            _mouseHandler.LeftClick(-634, 902);
            Thread.Sleep(3000);
            _mouseHandler.LeftClick(-1113, 560, true, true);
            Thread.Sleep(2500);
            
            // click the trapdoor
            _mouseHandler.LeftClick(-1283, 209, true, true);
            Thread.Sleep(11_000);
            
            // show NPCs
            _mouseHandler.LeftClick(-62, 475);

            // bank
            _mouseHandler.LeftClick(-1167, 604, true, true);
            Thread.Sleep(2500);
            _mouseHandler.LeftClick(-1251, 501);
            Thread.Sleep(500);
            
            // deposit
            _mouseHandler.LeftClick(-1023, 969);

            // eat 3 food and 1 stam pot
            // quantity 1
            _mouseHandler.LeftClick(-1233, 976);

            // stam pot
            _mouseHandler.LeftClick(-1047, 429);

            // withdraw food
            for (var i = 0; i < 1; i++)
            {
                _mouseHandler.LeftClick(-1048, 464);
                Thread.Sleep(300);
            }

            // quantity all
            _mouseHandler.LeftClick(-1135, 975);

            // eat
            _mouseHandler.LeftClick(-507, 907);
            Thread.Sleep(1000);

            // lob 1
            _mouseHandler.RightClick(-590, 940);
            Thread.Sleep(300);
            _mouseHandler.LeftClick(-614, 1068);
            Thread.Sleep(1000);

            // withdraw essence
            _mouseHandler.LeftClick(-1044, 279);
            
            // fill pouches
            _mouseHandler.LeftClick(-595, 901);
            Thread.Sleep(150);
            _mouseHandler.LeftClick(-557, 901);
            
            // withdraw essence
            _mouseHandler.LeftClick(-1044, 279);
            
            // begin trekk to altar
            _mouseHandler.LeftClick(-1894, 414);
            Thread.Sleep(15_000);
            _mouseHandler.LeftClick(-1390, 1165);
            Thread.Sleep(6_000);
            _mouseHandler.LeftClick(-1269, 1165);
            Thread.Sleep(8_000);

            // click altar
            _mouseHandler.LeftClick(-1237, 1090);
            Thread.Sleep(7_000);

            // empty pouches
            _mouseHandler.LeftClick(-595, 901);
            Thread.Sleep(150);
            _mouseHandler.LeftClick(-557, 901);

            // click altar
            _mouseHandler.LeftClick(-1114, 710);
        }
    }
}