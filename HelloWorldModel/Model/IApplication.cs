
namespace HelloWorldModel.Model
{
    public interface IApplication
    {
        string HelloWorldTextForApp { get; }
        void SaveInformation(string message);
    }
}
