using RsAutoClicker;
using System.Diagnostics;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(GemMine));
var stopwatch = Stopwatch.StartNew();
var counter = 0;
while(counter < 146)//(stopwatch.ElapsedMilliseconds < 21600000) // 6 hours
{
    script.Do();
}

counter++;