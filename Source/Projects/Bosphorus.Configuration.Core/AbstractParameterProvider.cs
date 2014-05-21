namespace Bosphorus.Configuration.Core
{
    public abstract class AbstractParameterProvider : IParameterProvider
    {
        public string GetValue(string parameterName)
        {
            string parameterValue = GetValueInternal(parameterName);
            return parameterValue;
        }

        public abstract string GetValueInternal(string parameterName);
   }
}