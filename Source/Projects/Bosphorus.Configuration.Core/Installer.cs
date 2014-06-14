using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter.Provider;
using Bosphorus.Configuration.Core.Parameter.Provider.Decoration;
using Bosphorus.Container.Castle.Registration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core
{
    public class Installer : AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                allLoadedTypes
                    .BasedOn<IParameterProvider>()
                    .WithService
                    .AllInterfaces(),

                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<SafeGetDecorator>()
                    .IsDefault(),

                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<ExceptionDecorator>()
                    .IsDefault(),

                allLoadedTypes
                    .BasedOn<IConfiguration>()
                    .WithService
                    .Self()
                    .WithService
                    .AllInterfaces()
            );
        }
    }
}
