using Autofac;
using Autofac.Core;
using System;
using System.Linq;
using System.Reflection;


namespace Pattern.Di
{
    public static class DiContainer
    {
        public static IContainer Container { get; set; }
        public static void Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //builder.RegisterModule<Pattern.Data.DiModule>();
            //builder.RegisterModule<Pattern.Services.DiModule>();

            var modules = assemblies.SelectMany(a => a.GetExportedTypes().Where(t => !t.IsAbstract && typeof(IModule).IsAssignableFrom(t))).Select(p => (IModule)Activator.CreateInstance(p));
            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }
            Container = builder.Build();
        }

    }
}

