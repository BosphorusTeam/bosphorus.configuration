using System;
using System.Configuration;
using System.Linq;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Configuration.Default.Parameter.AppConfig
{
    public class AppConfigParameterProvider : IParameterProvider
    {
        public bool Contains(string key)
        {
            return ConfigurationManager.AppSettings.AllKeys.Contains(key);
        }

        public TValue GetValue<TValue>(string key)
        {
            string appSettingsValue = ConfigurationManager.AppSettings.Get(key);
            object parameterValue = Convert.ChangeType(appSettingsValue, typeof(TValue));
            return (TValue)parameterValue;
        }
   }
}