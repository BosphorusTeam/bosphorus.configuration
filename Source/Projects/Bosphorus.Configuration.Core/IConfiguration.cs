namespace Bosphorus.Configuration.Core
{
    public interface IConfiguration<TOwner>
    {
        string Name { get; }
    }
}
