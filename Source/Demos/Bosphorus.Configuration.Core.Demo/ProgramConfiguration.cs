using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Default.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration<Program>
    {
        public ProgramConfiguration(InMemoryParameterProvider inMemoryParameterProvider) 
            : base(inMemoryParameterProvider)
        {
        }

        public string Key1
        {
            get { return GetValue<string>("Key1"); }
        }

        public string Key2
        {
            get { return GetValue<string>("Key2"); }
        }
    }
}