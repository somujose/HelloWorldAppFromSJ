using HelloWorldModel.Model;

namespace HelloWorldModel.Factory
{
    public interface IPrintHelloWorldFactory
    {
        PrintHelloWorldBase CreatePrintHelloWorld();
    }
}
