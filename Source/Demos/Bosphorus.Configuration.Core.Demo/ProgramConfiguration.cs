namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration<Program>
    {
        public ProgramConfiguration(IParameterProvider parameterProvider) 
            : base(parameterProvider)
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