using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration
    {
        public ProgramConfiguration(IParameterProvider parameterProvider) 
            : base("Bosphorus.Configuration.Core.Demo", parameterProvider)
        {
        }

        public string Key1 => GetValue<string>("Key1");

        public string Key2 => GetValue<string>("Key2");
    }
}