using System;

namespace Bosphorus.Configuration.Core.Parameter.Provider
{
    public static class ParameterProviderExtensions
    {
        public static TEnum GetValueAsEnum<TEnum>(this IParameterProvider extended, string parameterName)
        {
            string parameterValue = extended.GetValue<string>(parameterName);
            Type enumType = typeof (TEnum);
            TEnum result = (TEnum) Enum.Parse(enumType, parameterValue);
            return result;
        }
    }
}
