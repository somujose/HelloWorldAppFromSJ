
using HelloWorldModel.Factory;
using HelloWorldModel.Model;
using Moq;
using NUnit.Framework;
namespace HelloWorldModel.Test.Factories
{
    [TestFixture, Category("UnitTest")]
    public sealed class WhenPrintHelloWorldFactoryIsUsed
    {
        private IPrintHelloWorldFactory _printHelloWorldFactory;
        private Mock<IApplication> _mockApplication;
        [SetUp]
        public void SetUp()
        {
            _mockApplication = new Mock<IApplication>();
            _printHelloWorldFactory = new PrintHelloWorldFactory(_mockApplication.Object);
        }

        #region Test
        [Test]
        public void ThatCreateMethodWillCreateInstanceOfPrintHelloWorld()
        {
            var printHelloWorld = _printHelloWorldFactory.CreatePrintHelloWorld();
            Assert.That(printHelloWorld, Is.InstanceOf<PrintHelloWorldBase>());
        }
        #endregion
    }
}
