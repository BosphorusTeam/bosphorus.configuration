using System;
using Bosphorus.Common.Clr.Exception;

namespace Bosphorus.Configuration.Core.Parameter.Provider.Decoration
{
    public class ParameterProviderGetValueFailedException : ExceptionBase
    {
        public ParameterProviderGetValueFailedException(IParameterProvider parameterProvider, string parameterName, Exception exception)
            :base(ExceptionMessage.Build("ParameterProvider GetValue failed").Add("ParameterProviderName", parameterProvider.Name).Add("ParameterName", parameterName), exception)
        {
        }
    }
}