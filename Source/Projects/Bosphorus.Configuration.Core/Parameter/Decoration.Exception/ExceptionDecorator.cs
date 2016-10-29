namespace Bosphorus.Configuration.Core.Parameter.Decoration.Exception
{
    public class ExceptionDecorator: IParameterProvider
    {
        private readonly IParameterProvider decorated;

        public ExceptionDecorator(IParameterProvider decorated)
        {
            this.decorated = decorated;
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
                throw new ParameterProviderException("ParameterProvider ContainsKey failed", decorated, key, exception);
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
                throw new ParameterProviderException("ParameterProvider GetOptionalValue failed", decorated, key, exception);
            }
        }
    }
}