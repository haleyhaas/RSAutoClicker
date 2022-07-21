using System.Diagnostics;

namespace RsAutoClicker;


public class Program
{
    static void Main(string[] args)
    {
        Thread.Sleep(2000);
        var mouseHandler = new MouseHandler();
        var runecrafting = new Runecrafting(mouseHandler, true);
        var hunter = new Hunter(mouseHandler);
        var mining = new Mining(mouseHandler);

        var items = 1;
        var stopwatch = new Stopwatch();
        
        stopwatch.Start();
                
        while (items > 0)
        {
            hunter.Do();
            runecrafting.Do();
            mining.Do();

            // decrement items here
            items -= 0;
        }
    }          
}