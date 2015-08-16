using Bosphorus.Configuration.Core.Parameter.Decoration.Exception;
using Bosphorus.Configuration.Core.Parameter.Decoration.Safe;

namespace Bosphorus.Configuration.Core.Parameter
{
    public static class Decorations
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
