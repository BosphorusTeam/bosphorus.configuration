using System;

namespace Bosphorus.Configuration.Core.Parameter
{
    public static class Extensions
    {
        public static TEnum GetValueAsEnum<TEnum>(this IParameterProvider extended, string parameterName)
        {
            string parameterValue = extended.GetValue<string>(parameterName);
            Type enumType = typeof (TEnum);
            TEnum result = (TEnum) Enum.Parse(enumType, parameterValue);
            return result;
        }

        public static TValue GetMandatoryValue<TValue>(this IParameterProvider extended, string key)
        {
            bool exist = extended.Contains(key);
            if (!exist)
            {
                throw new ParameterNotExistsException(extended, key);
            }

            TValue result = extended.GetValue<TValue>(key);
            return result;
        }

        public static TValue GetOptionalValue<TValue>(this IParameterProvider extended, string key)
        {
            TValue result = extended.GetValue<TValue>(key);
            return result;
        }

        public static TValue GetOptionalValue<TValue>(this IParameterProvider extended, string key, TValue fallbackValue)
        {
            TValue result = extended.GetValue<TValue>(key);
            if (result != null)
            {
                return result;
            }

            return fallbackValue;
        }
    }
}
