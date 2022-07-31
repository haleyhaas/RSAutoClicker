using RsAutoClicker;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(CannonClicker));

while (true)
{
    script.Do();
}