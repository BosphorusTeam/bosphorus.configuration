using System.Collections.Generic;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Configuration.Default.Parameter.InMemory
{
    public class InMemoryParameterProvider: IParameterProvider
    {
        private readonly IDictionary<string, object> backingStore;

        public InMemoryParameterProvider()
        {
            backingStore = new Dictionary<string, object>();
        }

        public bool Contains(string key)
        {
            return backingStore.ContainsKey(key);
        }

        public TValue GetValue<TValue>(string key)
        {
            object result = backingStore[key];
            return (TValue)result;
        }

        public void SetValue(string parameterName, object parameterValue)
        {
            backingStore[parameterName] = parameterValue;
        }
    }
}
