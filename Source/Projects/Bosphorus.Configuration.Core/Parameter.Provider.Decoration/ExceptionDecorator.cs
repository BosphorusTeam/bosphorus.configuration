using System;

namespace Bosphorus.Configuration.Core.Parameter.Provider.Decoration
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

        public bool ContaintsParameter(string parameterName)
        {
            try
            {
                bool result = decorated.ContaintsParameter(parameterName);
                return result;
            }
            catch (Exception exception)
            {
                throw new ParameterProviderContainsKeyFailedException(decorated, parameterName, exception);
            }
            
        }

        public string GetValue(string parameterName)
        {
            try
            {
                string result = decorated.GetValue(parameterName);
                return result;
            }
            catch (Exception exception)
            {
                throw new ParameterProviderGetValueFailedException(decorated, parameterName, exception);
            }
        }
    }
}