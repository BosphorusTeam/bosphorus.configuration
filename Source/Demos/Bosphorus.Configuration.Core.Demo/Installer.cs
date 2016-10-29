using Bosphorus.Configuration.Core.Parameter;
using Bosphorus.Configuration.Default.Parameter.AppConfig;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core.Demo
{
    public class Installer: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<AppConfigParameterProvider>(),

                Component
                    .For<ProgramConfiguration>()
            );
        }
    }
}
