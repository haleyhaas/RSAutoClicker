﻿using RsAutoClicker;
using System.Diagnostics;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(AgilityArdougne));
var stopwatch = Stopwatch.StartNew();
while (stopwatch.ElapsedMilliseconds < 18_000_0000)//21_600_000) // 6 hours
{
    script.Do();
}