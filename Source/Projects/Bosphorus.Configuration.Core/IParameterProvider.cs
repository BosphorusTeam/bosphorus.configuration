namespace Bosphorus.Configuration.Core
{
    public interface IParameterProvider
    {
        string GetValue(string parameterName);
    }
}
