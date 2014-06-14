using System.Configuration;
using System.Linq;
using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Default
{
    public class AppConfigParameterProvider : AbstractParameterProvider
    {
        public AppConfigParameterProvider() 
            : base("AppConfigParameterProvider")
        {
        }

        protected override bool ContaintsParameterInternal(string parameterName)
        {
            bool parameterExists = ConfigurationManager.AppSettings.AllKeys.Contains(parameterName);
            return parameterExists;
        }

        public override string GetValueInternal(string parameterName)
        {
            string parameterValue = ConfigurationManager.AppSettings.Get(parameterName);
            return parameterValue;
        }
    }
}