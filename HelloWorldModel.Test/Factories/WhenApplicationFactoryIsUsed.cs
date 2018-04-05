
using HelloWorldModel.Factory;
using HelloWorldModel.Model;
using NUnit.Framework;

namespace HelloWorldModel.Test.Factories
{
    [TestFixture,Category("UnitTest")]
    public sealed class WhenApplicationFactoryIsUsed
    {
        private IApplicationFactory _applicationFactory;
        private ApplicationType applicationType = ApplicationType.Console;

        #region setUp
        [SetUp]
        public void SetUp()
        {
            _applicationFactory = new ApplicationFactory(applicationType);
        }

        #endregion


        #region Test
        [Test]
        public void ThatCreateMethodWillCreateInstanceOfApplication()
        {
            const string helloWorldText = "Hello from Console Application";
            var application = _applicationFactory.CreateApplication();
            Assert.That(application, Is.InstanceOf<IApplication>());
            Assert.That(application.HelloWorldTextForApp, Is.EqualTo(helloWorldText));
        }
        #endregion
    }
}
