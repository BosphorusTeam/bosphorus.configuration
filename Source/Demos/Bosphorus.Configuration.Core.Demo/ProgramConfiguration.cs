using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: IConfiguration
    {
        private readonly IParameterProvider parameterProvider;

        public string Key1 => parameterProvider.GetOptionalValue<string>(nameof(Key1));
        public string Key2 => parameterProvider.GetOptionalValue<string>(nameof(Key2));

        public ProgramConfiguration(IParameterProvider parameterProvider)
        {
            this.parameterProvider = parameterProvider;
        }

    }
}