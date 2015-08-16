using System;

namespace Bosphorus.Configuration.Default.Parameter.InMemory
{
    public static class Extensions
    {
        public static void SetValueAsEnum<TEnum>(this InMemoryParameterProvider extended, string parameterName, TEnum parameterValue)
        {
            Type enumType = typeof (TEnum);
            string parameterValueString = Enum.GetName(enumType, parameterValue);
            extended.SetValue(parameterName, parameterValueString);
        }
    }
}
