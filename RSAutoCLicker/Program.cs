using RsAutoClicker;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(Runecrafting));

while (true)
{
    script.Do();
}