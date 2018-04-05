using HelloWorldModel.Model;

namespace HelloWorldModel.Factory
{
    public sealed class PrintHelloWorldFactory : IPrintHelloWorldFactory
    {
        private readonly IApplication _application;

        public PrintHelloWorldFactory(IApplication application)
        {
            _application = application;
        }
        public PrintHelloWorldBase CreatePrintHelloWorld()
        {
            return new PrintHelloWorld(_application);
        }
    }
}
