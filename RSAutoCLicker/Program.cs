using RsAutoClicker;
using System.Diagnostics;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(RunecraftingLava));
var count = 535;
var stopwatch = new Stopwatch();
stopwatch.Start();

var stop = 21600000;
while (stopwatch.ElapsedMilliseconds < stop)
{
    script.Do();
}