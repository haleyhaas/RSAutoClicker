using RsAutoClicker;
using System.Diagnostics;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(TitheFarm));
var stopwatch = Stopwatch.StartNew();

for(var i = 0; i < 267; i++)
{
    script.Do();
}

//while (stopwatch.ElapsedMilliseconds < 21_600_000) // 6 hours
//{
//    script.Do();
//}