using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ServiceConfiguration: AbstractConfiguration
    {
        public ServiceConfiguration(string name, IParameterProvider parameterProvider) 
            : base(name, parameterProvider)
        {
        }
    }
}
