using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Default.AppConfig;
using Bosphorus.Configuration.Default.InMemory;
using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Default.Registration
{
    public class Installer: AbstractWindsorInstaller, IInfrastructureInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                /*
            Component
                .For<IParameterProvider>()
                .Forward<IAppConfigParameterProvider>()
                .ImplementedBy<AppConfigParameterProvider>()
                .IsFallback()
                .NamedUnique(),

            Component
                .For(typeof(IDatabaseParameterProvider<>))
                .ImplementedBy(typeof(DatabaseParameterProvider<>))
                .IsFallback()
                .NamedUnique(),

                Component
                    .For<IInMemoryParameterProvider>()
                    .ImplementedBy<InMemoryParameterProvider>()
                    .IsFallback()
                    .NamedUnique()
                */
            );
        }
    }
}
