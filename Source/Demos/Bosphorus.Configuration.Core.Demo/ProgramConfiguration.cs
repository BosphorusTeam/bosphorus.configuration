using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration
    {
        public ProgramConfiguration(IParameterProvider parameterProvider) 
            : base("Program", parameterProvider)
        {
        }

        public string Key1
        {
            get { return parameterProvider.GetValue("Key1"); }
        }

        public string Key2
        {
            get { return parameterProvider.GetValue("Key2"); }
        }
    }
}