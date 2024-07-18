using Microsoft.Extensions.Logging;

namespace iosMauiInterop
{
    public static class MauiProgram
    {
        public static IInvoker Invoker { get; private set; }

        public static MauiApp CreateMauiApp<TInvoker>()
            where TInvoker : class, IInvoker, new()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            Invoker = new TInvoker();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
