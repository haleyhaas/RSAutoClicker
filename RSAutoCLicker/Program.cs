using RsAutoClicker;

Thread.Sleep(2000);
var mouseHandler = new MouseHandler();
var runecrafting = new Runecrafting(mouseHandler, true);
var hunter = new Hunter(mouseHandler);
var mining = new Mining(mouseHandler);

while (true)
{
    hunter.Do();
    runecrafting.Do();
    mining.Do();
}