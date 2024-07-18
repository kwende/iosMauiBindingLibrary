namespace iosMauiInterop.Platforms.iOS
{
    internal class Invoker : IInvoker
    {
        public string ReturnStringWithInput(string input)
        {
            Binding.SwiftLibrary swiftLibrary = new Binding.SwiftLibrary();
            return swiftLibrary.ReturnStringWithInput(input);
        }
    }
}
