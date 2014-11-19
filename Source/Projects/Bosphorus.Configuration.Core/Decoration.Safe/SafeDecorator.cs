namespace Bosphorus.Configuration.Core.Decoration.Safe
{
    class SafeDecorator: IParameterProvider
    {
        private readonly IParameterProvider decorated;

        public SafeDecorator(IParameterProvider decorated)
        {
            this.decorated = decorated;
        }

        public string Name
        {
            get { return decorated.Name; }
        }

        public bool Contains(string key)
        {
            bool result = decorated.Contains(key);
            return result;
        }

        public TValue GetValue<TValue>(string key)
        {
            bool containtsParameter = Contains(key);
            if (!containtsParameter)
            {
                throw new ParameterNotExistsException(decorated, key);
            }

            TValue result = decorated.GetValue<TValue>(key);
            return result;
        }
    }
}
