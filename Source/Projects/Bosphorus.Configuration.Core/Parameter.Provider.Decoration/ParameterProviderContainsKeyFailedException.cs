using System;
using Bosphorus.Common.Clr.Exception;

namespace Bosphorus.Configuration.Core.Parameter.Provider.Decoration
{
    public class ParameterProviderContainsKeyFailedException : ExceptionBase
    {
        public ParameterProviderContainsKeyFailedException(IParameterProvider parameterProvider, string parameterName, Exception exception)
            : base(ExceptionMessage.Build("ParameterProvider contains key failed").Add("ParameterProviderName", parameterProvider.Name).Add("ParameterName", parameterName), exception)
        {
        }
    }
}