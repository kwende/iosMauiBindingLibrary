using Foundation;
using iosMauiInterop.Platforms.iOS;

namespace iosMauiInterop
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp<Invoker>();
    }
}
