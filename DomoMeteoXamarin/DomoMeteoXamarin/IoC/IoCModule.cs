using Autofac;
using DomoMeteoXamarin.Services;

namespace DomoMeteoXamarin.IoC
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DomoticzAPI>()
                    .As<IDomoticzAPI>()
                    .SingleInstance();
        }
    }
}
