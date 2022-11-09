using RsAutoClicker;

Thread.Sleep(2000);
var script = SkillActivator.Activate(typeof(AgilityPrif));
var count = 222;
while (count > 0)
{
    script.Do();
    count--;
}