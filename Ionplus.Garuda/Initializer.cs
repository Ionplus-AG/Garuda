namespace Ionplus.Garuda
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Ionplus.Garuda.Model;

    public static class Initializer
    {
        public static IConnection InitializeConnection(Assembly assembly, InitializeData data)
        {
            var connectionType = assembly.GetTypes().SingleOrDefault(t => t.IsInstanceOfType(typeof(IConnection)));
            if (connectionType == null)
            {
                throw new ArgumentException("No implementation of type 'IConnection' found.");
            }

            var types = new Type[1];
            types[0] = typeof(InitializeData);
            var constructor = connectionType.GetConstructor(types);
            if (constructor == null)
            {
                throw new ArgumentException("Implementation of type 'IConnection' is missing an constructor with 'InitializeData'");
            }

            return (IConnection)constructor.Invoke(new object[] { data });
        }
    }
}
