
using System.ComponentModel;

namespace HelloWorldModel.Model
{
    public enum ApplicationType
    {
        [Description("Console Application")]
        Console,
        [Description("Web Api Application")]
        WebAPI,
        [Description("MVC Application")]
        MVC,
        [Description("Desktop Application")]
        Desktop
    }
}
