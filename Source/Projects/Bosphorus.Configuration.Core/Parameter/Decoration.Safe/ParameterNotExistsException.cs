using Bosphorus.Common.Clr.Exception;

namespace Bosphorus.Configuration.Core.Parameter.Decoration.Safe
{
    public class ParameterNotExistsException : ExceptionBase
    {
        public ParameterNotExistsException(IParameterProvider parameterProvider, string parameterName)
            : base(ExceptionMessage.Build("Parameter not exists exception").Add("ParameterProviderName", parameterProvider.Name).Add("ParameterName", parameterName))
        {
        }
    }
}