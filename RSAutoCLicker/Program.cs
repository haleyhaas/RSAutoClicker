using RsAutoClicker;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(Construction));
var count = 12000;
while (count > 0)
{
    script.Do();
    count--;
}