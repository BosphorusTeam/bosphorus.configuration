namespace Bosphorus.Configuration.Core
{
    public interface IParameterProvider
    {
        string Name { get; }

        bool Contains(string key);

        TValue GetValue<TValue>(string key);
    }
}
