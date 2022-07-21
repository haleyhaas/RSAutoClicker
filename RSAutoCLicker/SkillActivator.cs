namespace RsAutoClicker
{
    public static class SkillActivator
    {
        public static IScripter Activate(Type type)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IScripter).IsAssignableFrom(p));

            var t = types.FirstOrDefault(x => x == type);
            if (t == null) throw new ArgumentOutOfRangeException($"Could not find {nameof(IScripter)} type of {type.Name}");
            return CreateInstance<IScripter>(t, new MouseHandler());
        }

        private static T CreateInstance<T>(Type t, params object[] paramArray)
        {
            return (T)Activator.CreateInstance(t, args: paramArray);
        }
    }
}
