using System;

namespace HelloWorldModel.Model
{
    public sealed class PrintHelloWorld : PrintHelloWorldBase
    {
        private readonly IApplication _application;

        public PrintHelloWorld(IApplication application)
        {
            _application = application;
        }


        public override string CreateHelloWorldInformation()
        {
            var helloWorldText = _application.HelloWorldTextForApp;
            //for all application except WebAPI this will invoke base class method
            //For Web API alone we have orveridden the method to save data to sql server.
            _application.SaveInformation(helloWorldText);
            return helloWorldText;
        }
    }
}
