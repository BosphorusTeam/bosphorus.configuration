using System;

namespace Bosphorus.Configuration.Default.InMemory
{
    public static class InMemoryParameterProviderExtensions
    {
        public static void SetValueAsEnum<TEnum>(this InMemoryParameterProvider extended, string parameterName, TEnum parameterValue)
        {
            Type enumType = typeof (TEnum);
            string parameterValueString = Enum.GetName(enumType, parameterValue);
            extended.SetValue(parameterName, parameterValueString);
        }
    }
}
