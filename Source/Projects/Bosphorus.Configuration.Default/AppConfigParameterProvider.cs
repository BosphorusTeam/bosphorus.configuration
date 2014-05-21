using System.Configuration;
using Bosphorus.Configuration.Core;

namespace Bosphorus.Configuration.Default
{
    public class AppConfigParameterProvider : AbstractParameterProvider
    {
        public override string GetValueInternal(string parameterName)
        {
            string parameterValue = ConfigurationManager.AppSettings.Get(parameterName);
            return parameterValue;
        }
    }
}