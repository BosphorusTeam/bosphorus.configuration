﻿namespace Bosphorus.Configuration.Core
{
    public abstract class AbstractConfiguration<TOwner> : IConfiguration<TOwner>
    {
        private readonly string name;
        private readonly IParameterProvider parameterProvider;

        protected AbstractConfiguration(IParameterProvider parameterProvider)
        {
            this.name = typeof(TOwner).FullName;
            this.parameterProvider = parameterProvider;
        }

        public string Name 
        {
            get { return name; }
        }

        protected TValue GetValue<TValue>(string parameterName)
        {
            var parameterFullName = GetFullParameterName(parameterName);
            TValue result = parameterProvider.GetValue<TValue>(parameterFullName);

            return result;
        }

        protected TValue GetValue<TValue>(string parameterName, TValue fallbackValue)
        {
            string parameterFullName = GetFullParameterName(parameterName);
            bool contains = parameterProvider.Contains(parameterFullName);
            if (!contains)
            {
                return fallbackValue;
            }

            TValue result = GetValue<TValue>(parameterName);
            return result;
        }

        private string GetFullParameterName(string parameterName)
        {
            string parameterFullName = string.Format("{0}.{1}", name, parameterName);
            return parameterFullName;
        }

    }
}
