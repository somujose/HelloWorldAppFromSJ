using HelloWorldModel.Model;
using HelloWorldModel.Factory;
using HelloWorldModel.Utilities;
using NUnit.Framework;
using Moq;

namespace HelloWorldModel.Test.Model
{
    [TestFixture, Category("UnitTest")]
    public sealed class WhenDesktopApplicationIsUsed
    {
        private Mock<IApplicationFactory> _mockApplicationFactory;
        private Mock<IPrintHelloWorldFactory> _mockPrintHelloWorldFactory;
        private Mock<PrintHelloWorldBase> _mockPrintHelloWorld;
        private ApplicationType applicationType = ApplicationType.Desktop;
        private const string HelloWorldtext = "Hello from Desktop Application";


        #region setUp
        [SetUp]
        public void SetUp()
        {
            _mockApplicationFactory = new Mock<IApplicationFactory>();
            _mockPrintHelloWorldFactory = new Mock<IPrintHelloWorldFactory>();
            _mockPrintHelloWorld = new Mock<PrintHelloWorldBase>();

            _mockApplicationFactory.Setup(x => x.CreateApplication()).Returns(new DesktopApplication(applicationType.GetEnumDescription()));
            _mockPrintHelloWorldFactory.Setup(x => x.CreatePrintHelloWorld()).Returns(_mockPrintHelloWorld.Object);
            _mockPrintHelloWorld.Setup(x => x.CreateHelloWorldInformation()).Returns(HelloWorldtext);

        }

        #region Test
        [Test]
        public void CreateHelloWorldInformationWillReturnDesktopHelloWorldText()
        {
            var helloWorldText = _mockPrintHelloWorld.Object.CreateHelloWorldInformation();
            Assert.That(helloWorldText, Is.EqualTo(HelloWorldtext));
        }
        #endregion

        #endregion

    }
}
