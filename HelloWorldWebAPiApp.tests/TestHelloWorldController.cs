using System.Web.Http.Results;
using HelloWorldWebAPIApp.Controllers;
using HelloWorldWebAPIApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWebAPiApp.tests
{
    [TestClass]
    public class TestHelloWorldController
    {
        private const string helloWorldText = "Hello from Web Api Application";

        [TestMethod]
        public void GetHelloWorldTextShouldReturnHelloWorldMessage()
        {
            var controller = new HelloWorldController();
            var response = controller.GetHelloworldText();
            var result = response as JsonResult<HelloWorldWebAPIModel>;
            Assert.IsNotNull(result);
            Assert.AreEqual(helloWorldText, result.Content.HelloWorldString);
        }

        [TestMethod]
        public void GetHelloWorldTextWithIdShouldReturnHelloWorldMessage()
        {
            var controller = new HelloWorldController();
            var response = controller.GetHelloworldText(3);
            var result = response as JsonResult<HelloWorldWebAPIModel>;
            Assert.IsNotNull(result);
            Assert.AreEqual(helloWorldText, result.Content.HelloWorldString);
        }

    }
}
