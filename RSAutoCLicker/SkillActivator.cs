namespace RsAutoClicker
{
    public static class SkillActivator
    {
        public static IScripter Activate(Type type)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IScripter).IsAssignableFrom(p));

            foreach(var t in types)
            {
                if(t == type)
                {
                    return CreateInstance<IScripter>(t, new MouseHandler());
                }
            }

            return null;
        }

        private static T CreateInstance<T>(Type t, params object[] paramArray)
        {
            return (T)Activator.CreateInstance(t, args: paramArray);
        }
    }
}
