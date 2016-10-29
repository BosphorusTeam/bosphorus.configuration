using Bosphorus.Configuration.Core.Parameter.Decoration.Exception;

namespace Bosphorus.Configuration.Core.Parameter
{
    public static class Decorations
    {
        public static IParameterProvider Exceptioned(this IParameterProvider extended)
        {
            IParameterProvider decorated = new ExceptionDecorator(extended);
            return decorated;
        }
    }
}
