using Bosphorus.Configuration.Core;

namespace Bosphorus.Configuration.Default.InMemory
{
    public interface IInMemoryParameterProvider: IParameterProvider
    {
        void SetValue(string parameterName, object parameterValue);
    }
}
