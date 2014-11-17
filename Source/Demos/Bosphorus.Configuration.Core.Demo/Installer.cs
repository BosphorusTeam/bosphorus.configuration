using Bosphorus.Configuration.Default.AppConfig;
using Bosphorus.Container.Castle.Registration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core.Demo
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<AppConfigParameterProvider>(),

                Component
                    .For<ProgramConfiguration>()
                    .ImplementedBy<ProgramConfiguration>()
            );
        }
    }
}
