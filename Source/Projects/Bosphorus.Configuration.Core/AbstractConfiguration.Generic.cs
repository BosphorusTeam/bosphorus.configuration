namespace Bosphorus.Configuration.Core
{
    public abstract class AbstractConfiguration<TOwner> : AbstractConfiguration
    {
        private static readonly string ownerTypeName;

        static AbstractConfiguration()
        {
            ownerTypeName = typeof (TOwner).FullName;
        }

        protected AbstractConfiguration(IParameterProvider parameterProvider) 
            : base(ownerTypeName, parameterProvider)
        {
        }
    }
}