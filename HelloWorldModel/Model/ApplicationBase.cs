using System;

namespace HelloWorldModel.Model
{
    public class ApplicationBase : IApplication
    {
        private readonly string _applicationDescription;
        public string HelloWorldTextForApp => $"Hello from {_applicationDescription}";


        public ApplicationBase(string applicationDescription)
        {
            _applicationDescription = applicationDescription;
        }
        public virtual void SaveInformation(string message)
        {
            // Default implementation to Save Information to console or to file
            // used by all other application except Web Api 
        }
    }
}
