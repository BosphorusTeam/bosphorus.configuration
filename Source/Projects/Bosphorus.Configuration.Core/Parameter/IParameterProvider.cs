namespace Bosphorus.Configuration.Core.Parameter
{
    public interface IParameterProvider
    {
        bool Contains(string key);

        TValue GetValue<TValue>(string key);
    }
}
