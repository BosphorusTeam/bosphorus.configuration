using System;

namespace Bosphorus.Configuration.Default.Parameter.Provider
{
    public static class InMemoryParameterProviderExtensions
    {
        public static void SetValueAsEnum<TEnum>(this InMemoryParameterProvider extended, string parameterName, TEnum parameterValue)
        {
            Type enumType = typeof (TEnum);
            string parameterValueString = Enum.GetName(enumType, parameterValue);
            extended.SetValue("Perspective", parameterValueString);
        }
    }
}
