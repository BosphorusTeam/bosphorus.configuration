namespace Bosphorus.Configuration.Core
{
    public abstract class AbstractConfiguration : IConfiguration
    {
        private readonly string name;
        protected readonly IParameterProvider parameterProvider;

        protected AbstractConfiguration(string name, IParameterProvider parameterProvider)
        {
            this.name = name;
            this.parameterProvider = parameterProvider;
        }

        public string Name 
        {
            get { return name; }
        }
    }
}