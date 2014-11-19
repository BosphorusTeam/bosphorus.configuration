using System;
using Bosphorus.Configuration.Core.Decoration.Exception;
using Bosphorus.Configuration.Core.Decoration.Safe;

namespace Bosphorus.Configuration.Core
{
    public static class IParameterProviderDecorations
    {
        public static IParameterProvider Safe(this IParameterProvider extended)
        {
            IParameterProvider decorated = new SafeDecorator(extended);
            return decorated;
        }

        public static IParameterProvider Exceptioned(this IParameterProvider extended)
        {
            IParameterProvider decorated = new ExceptionDecorator(extended);
            return decorated;
        }

    }
}
