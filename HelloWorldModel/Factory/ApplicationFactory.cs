
using System;
using HelloWorldModel.Model;
using HelloWorldModel.Utilities;

namespace HelloWorldModel.Factory
{
    public sealed class ApplicationFactory : IApplicationFactory
    {
        private readonly ApplicationType _applicationType;
        public ApplicationFactory(ApplicationType applicationType)
        {
            _applicationType = applicationType;
        }

        public IApplication CreateApplication()
        {
            var applicationDescription = _applicationType.GetEnumDescription();
            IApplication application;
            switch (_applicationType)
            {
                case ApplicationType.Console:
                    application = new ConsoleApplication(applicationDescription);
                    break;
                case ApplicationType.WebAPI:
                    application = new WebAPIApplication(applicationDescription);
                    break;
                case ApplicationType.MVC:
                    application = new MVCApplication(applicationDescription);
                    break;
                case ApplicationType.Desktop:
                    application = new DesktopApplication(applicationDescription);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return application;
        }
    }
}
