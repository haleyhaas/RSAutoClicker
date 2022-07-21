using RsAutoClicker;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(Agility));

while (true)
{
    script.Do();
}