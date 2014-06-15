using System.Collections.Generic;
using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Default.Parameter.Provider
{
    public class InMemoryParameterProvider: AbstractParameterProvider
    {
        private readonly IDictionary<string, string> backingStore;

        public InMemoryParameterProvider()
        {
            backingStore = new Dictionary<string, string>();
        }

        protected override bool ContaintsParameterInternal(string parameterName)
        {
            bool result = backingStore.ContainsKey(parameterName);
            return result;
        }

        protected override string GetValueInternal(string parameterName)
        {
            string result = backingStore[parameterName];
            return result;
        }

        public void SetValue(string parameterName, string parameterValue)
        {
            backingStore[parameterName] = parameterValue;
        }
    }
}
