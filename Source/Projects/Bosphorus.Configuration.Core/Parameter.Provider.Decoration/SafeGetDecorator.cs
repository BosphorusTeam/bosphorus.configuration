namespace Bosphorus.Configuration.Core.Parameter.Provider.Decoration
{
    class SafeGetDecorator: IParameterProvider
    {
        private readonly IParameterProvider decorated;

        public SafeGetDecorator(IParameterProvider decorated)
        {
            this.decorated = decorated;
        }

        public string Name
        {
            get { return decorated.Name; }
        }

        public bool ContaintsParameter(string parameterName)
        {
            bool result = decorated.ContaintsParameter(parameterName);
            return result;
        }

        public string GetValue(string parameterName)
        {
            bool containtsParameter = ContaintsParameter(parameterName);
            if (!containtsParameter)
            {
                throw new ParameterNotExistsException(decorated, parameterName);
            }

            string result = decorated.GetValue(parameterName);
            return result;
        }
    }
}
