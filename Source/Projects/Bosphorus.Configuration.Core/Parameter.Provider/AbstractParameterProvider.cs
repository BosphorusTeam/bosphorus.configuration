namespace Bosphorus.Configuration.Core.Parameter.Provider
{
    public abstract class AbstractParameterProvider : IParameterProvider
    {
        private readonly string name;

        protected AbstractParameterProvider()
        {
            this.name = this.GetType().Name;
        }

        protected AbstractParameterProvider(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public bool ContaintsParameter(string parameterName)
        {
            bool result = ContaintsParameterInternal(parameterName);
            return result;
        }

        protected abstract bool ContaintsParameterInternal(string parameterName);

        public string GetValue(string parameterName)
        {
            string parameterValue = GetValueInternal(parameterName);
            return parameterValue;
        }

        protected abstract string GetValueInternal(string parameterName);
   }
}