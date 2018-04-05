
namespace HelloWorldConsoleApp
{
    using System;
    using HelloWorldModel.Factory;
    using HelloWorldModel.Model;
    class Program
    {
        static void Main(string[] args)
        {
            var appFactory = new ApplicationFactory(ApplicationType.WebAPI);
            var printHelloWorldFactory = new PrintHelloWorldFactory(appFactory.CreateApplication());
            var printHelloWorld = printHelloWorldFactory.CreatePrintHelloWorld();
            Console.WriteLine(printHelloWorld.CreateHelloWorldInformation());
            Console.ReadLine();
        }
    }
}
