using System;
using Bosphorus.Configuration.Core.Parameter.Provider;

namespace Bosphorus.Configuration.Core.Configuration
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