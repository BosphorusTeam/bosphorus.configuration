namespace Bosphorus.Configuration.Core.Parameter.Provider
{
    public interface IParameterProvider
    {
        string Name { get; }

        bool ContaintsParameter(string parameterName);

        string GetValue(string parameterName);
    }
}
