
namespace LiteApp.RyarcWork.ViewModels.Validation
{
    public interface IValidator
    {
        void AddError(string propertyName, string message);

        void RemoveError(string propertyName);

        void Validate();

        string GetPropertyErrorMessage(string propertyName);

        bool HasErrors { get; }

        object Target { get; set; }
    }
}
