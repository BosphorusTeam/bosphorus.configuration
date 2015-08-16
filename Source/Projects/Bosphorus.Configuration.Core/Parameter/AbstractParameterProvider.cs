namespace Bosphorus.Configuration.Core.Parameter
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

        public bool Contains(string key)
        {
            bool result = ContainsInternal(key);
            return result;
        }

        protected abstract bool ContainsInternal(string parameterName);

        public TValue GetValue<TValue>(string key)
        {
            TValue parameterValue = GetValueInternal<TValue>(key);
            return parameterValue;
        }

        protected abstract TValue GetValueInternal<TValue>(string parameterName);
   }
}