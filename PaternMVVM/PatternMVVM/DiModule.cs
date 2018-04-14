using Autofac;
using Pattern.Data.Factories;
using Pattern.Data.Repositories;

namespace Pattern.Services
{
    public class DiModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<SaveServices>().AsImplementedInterfaces();
            builder.RegisterType<PatternRepositorie>().AsImplementedInterfaces();
            builder.RegisterType<DbContextFactory>().AsImplementedInterfaces();
        }
    }
}
