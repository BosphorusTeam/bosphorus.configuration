using Bosphorus.Common.Api.Exception;

namespace Bosphorus.Configuration.Core.Parameter
{
    public class ParameterNotExistsException : ExceptionBase
    {
        public ParameterNotExistsException(IParameterProvider parameterProvider, string parameterName)
            : base(ExceptionMessage.Build("Parameter not exists exception")
                  .Add(nameof(parameterProvider), parameterProvider)
                  .Add(nameof(parameterName), parameterName))
        {
        }
    }
}