using System;
using System.Configuration;
using System.Linq;
using Bosphorus.Configuration.Core;

namespace Bosphorus.Configuration.Default.AppConfig
{
    public class AppConfigParameterProvider : AbstractParameterProvider, IAppConfigParameterProvider
    {
        public AppConfigParameterProvider() 
            : base("AppConfigParameterProvider")
        {
        }

        protected override bool ContainsInternal(string parameterName)
        {
            bool parameterExists = ConfigurationManager.AppSettings.AllKeys.Contains(parameterName);
            return parameterExists;
        }

        protected override TValue GetValueInternal<TValue>(string parameterName)
        {
            string appSettingsValue = ConfigurationManager.AppSettings.Get(parameterName);
            object parameterValue = Convert.ChangeType(appSettingsValue, typeof(TValue));
            return (TValue) parameterValue;
        }
   }
}