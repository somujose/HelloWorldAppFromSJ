using System.Web.Http;
using HelloWorldModel.Factory;
using HelloWorldModel.Model;
using HelloWorldWebAPIApp.Models;

namespace HelloWorldWebAPIApp.Controllers
{
    public class HelloWorldController : ApiController
    {

        [HttpGet]
        public IHttpActionResult GetHelloworldText()
        {
            var model = new HelloWorldWebAPIModel
            {
                HelloWorldString = GetDatafromModel()
            };
            return Json(model);
        }

        [HttpGet]
        public IHttpActionResult GetHelloworldText(int id)
        {
            var model = new HelloWorldWebAPIModel
            {
                HelloWorldString = GetDatafromModel()
            };
            return Json(model);
        }

        private string GetDatafromModel()
        {
            var appFactory = new ApplicationFactory(ApplicationType.WebAPI);
            var printHelloWorldFactory = new PrintHelloWorldFactory(appFactory.CreateApplication());
            var printHelloWorld = printHelloWorldFactory.CreatePrintHelloWorld();
            return printHelloWorld.CreateHelloWorldInformation();
        }

    }
}
