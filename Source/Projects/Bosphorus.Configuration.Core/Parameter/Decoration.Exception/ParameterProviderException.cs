using Bosphorus.Common.Api.Exception;

namespace Bosphorus.Configuration.Core.Parameter.Decoration.Exception
{
    public class ParameterProviderException : ExceptionBase
    {
        public ParameterProviderException(string message, IParameterProvider parameterProvider, string parameterName, System.Exception exception)
            : base(ExceptionMessage.Build(message)
                  .Add(nameof(parameterProvider), parameterProvider)
                  .Add(nameof(parameterName), parameterName), exception)
        {
        }
    }
}