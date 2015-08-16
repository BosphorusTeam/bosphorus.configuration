using Bosphorus.Common.Clr.Exception;

namespace Bosphorus.Configuration.Core.Parameter.Decoration.Exception
{
    public class ParameterProviderContainsKeyFailedException : ExceptionBase
    {
        public ParameterProviderContainsKeyFailedException(IParameterProvider parameterProvider, string parameterName, System.Exception exception)
            : base(ExceptionMessage.Build("ParameterProvider contains key failed").Add("ParameterProviderName", parameterProvider.Name).Add("ParameterName", parameterName), exception)
        {
        }
    }
}