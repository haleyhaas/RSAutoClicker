using RsAutoClicker;

Thread.Sleep(2000);
var mouseHandler = new MouseHandler();
var runecrafting = new Runecrafting(mouseHandler, true);
var hunter = new Hunter(mouseHandler);
var mining = new Mining(mouseHandler);

var items = 1;

while (items > 0)
{
    hunter.Do();
    runecrafting.Do();
    mining.Do();

    // decrement items here
    items -= 0;
}