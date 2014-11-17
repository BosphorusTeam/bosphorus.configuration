using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Configuration
{
    public abstract class AbstractConfiguration : IConfiguration
    {
        private readonly string name;
        private readonly IParameterProvider parameterProvider;

        protected AbstractConfiguration(string name, IParameterProvider parameterProvider)
        {
            this.name = name;
            this.parameterProvider = parameterProvider;
        }

        public string Name 
        {
            get { return name; }
        }

        protected TValue GetValue<TValue>(string parameterName)
        {
            string parameterFullName = string.Format("{0}.{1}", name, parameterName);
            TValue result = parameterProvider.GetValue<TValue>(parameterFullName);

            return result;
        }
    }
}

