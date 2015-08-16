using System.Collections.Generic;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Configuration.Default.Parameter.InMemory
{
    public class InMemoryParameterProvider: AbstractParameterProvider
    {
        private readonly IDictionary<string, object> backingStore;

        public InMemoryParameterProvider()
        {
            backingStore = new Dictionary<string, object>();
        }

        protected override bool ContainsInternal(string parameterName)
        {
            bool result = backingStore.ContainsKey(parameterName);
            return result;
        }

        protected override TValue GetValueInternal<TValue>(string parameterName)
        {
            object result = backingStore[parameterName];
            return (TValue) result;
        }

        public void SetValue(string parameterName, object parameterValue)
        {
            backingStore[parameterName] = parameterValue;
        }
    }
}
