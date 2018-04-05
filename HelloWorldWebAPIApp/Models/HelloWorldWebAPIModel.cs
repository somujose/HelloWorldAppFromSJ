
using HelloWorldModel.Factory;
using HelloWorldModel.Model;

namespace HelloWorldWebAPIApp.Models
{
    public class HelloWorldWebAPIModel
    {
        public string HelloWorldString { get; set; }
        public static string GetDatafromModel()
        {
            var appFactory = new ApplicationFactory(ApplicationType.WebAPI);
            var printHelloWorldFactory = new PrintHelloWorldFactory(appFactory.CreateApplication());
            var printHelloWorld = printHelloWorldFactory.CreatePrintHelloWorld();
            return printHelloWorld.CreateHelloWorldInformation();
        }
    }
}