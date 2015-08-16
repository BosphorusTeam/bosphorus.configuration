using Bosphorus.Configuration.Core.Parameter;
using Bosphorus.Configuration.Core.Parameter.Decoration.Exception;
using Bosphorus.Configuration.Core.Parameter.Decoration.Safe;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Fluent.Decoration;
using Bosphorus.Container.Castle.Registration.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core
{
    public class DecorationInstaller: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Decorator
                    .Of<IParameterProvider>()
                    .Is<SafeDecorator>()
                    .Is<ExceptionDecorator>()
            );
        }
    }
}
