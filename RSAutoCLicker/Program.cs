using RsAutoClicker;
using System.Diagnostics;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(Construction));
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 21600000) // 6 hours
{
    script.Do();
}