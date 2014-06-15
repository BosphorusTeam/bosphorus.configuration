using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter.Provider;
using Bosphorus.Configuration.Default.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration
    {
        private readonly InMemoryParameterProvider inMemoryParameterProvider;

        public ProgramConfiguration(IParameterProvider parameterProvider, InMemoryParameterProvider inMemoryParameterProvider) 
            : base("Program", parameterProvider)
        {
            this.inMemoryParameterProvider = inMemoryParameterProvider;
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