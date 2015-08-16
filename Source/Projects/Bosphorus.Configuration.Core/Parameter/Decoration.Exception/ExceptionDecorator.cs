namespace Bosphorus.Configuration.Core.Parameter.Decoration.Exception
{
    class ExceptionDecorator: IParameterProvider
    {
        private readonly IParameterProvider decorated;

        public ExceptionDecorator(IParameterProvider decorated)
        {
            this.decorated = decorated;
        }

        public string Name
        {
            get { return decorated.Name; }
        }

        public bool Contains(string key)
        {
            try
            {
                bool result = decorated.Contains(key);
                return result;
            }
            catch (System.Exception exception)
            {
                throw new ParameterProviderContainsKeyFailedException(decorated, key, exception);
            }
            
        }

        public TValue GetValue<TValue>(string key)
        {
            try
            {
                TValue result = decorated.GetValue<TValue>(key);
                return result;
            }
            catch (System.Exception exception)
            {
                throw new ParameterProviderGetValueFailedException(decorated, key, exception);
            }
        }
    }
}