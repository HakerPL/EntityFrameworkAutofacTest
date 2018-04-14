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

            Console.WriteLine("Assembly.GetExecutingAssembly()");
            Console.WriteLine(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            Console.WriteLine("AppDomain.CurrentDomain.GetAssemblies()");
            Console.WriteLine(AppDomain.CurrentDomain.GetAssemblies());
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //builder.RegisterModule<Pattern.Data.DiModule>();
            //builder.RegisterModule<Pattern.Services.DiModule>();

            foreach (var assem in assemblies)
            {
                Console.WriteLine(assem.FullName);

                foreach (Type t in assem.GetExportedTypes())
                {
                    //Console.WriteLine(t);
                }
            }

            /*
             * true if the Type is abstract; otherwise, false.
             * t.IsAbstract
             * 
             * Determines whether an instance of a specified type can be assigned to an instance of the current type.
             * typeof(IModule).IsAssignableFrom(t)
             * 
             * Creates an instance of the specified type using that type's default constructor.
             * Activator.CreateInstance(p)
             * */

            var modules = assemblies.SelectMany(a => a.GetExportedTypes().Where(t => !t.IsAbstract && typeof(IModule).IsAssignableFrom(t))).Select(p => (IModule)Activator.CreateInstance(p));
            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            Container = builder.Build();
        }

    }
}

