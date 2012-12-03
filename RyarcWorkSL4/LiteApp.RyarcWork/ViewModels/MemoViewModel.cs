using System.ComponentModel;
using LiteApp.Portable.Mvvm.Validation;
using LiteApp.RyarcWork.Framework;

namespace LiteApp.RyarcWork.ViewModels
{
    public class MemoViewModel : EditableViewModel, IDataErrorInfo
    {
        string _name;

        public MemoViewModel()
        {
            RefreshBindingScope = new RefreshBindingScope();
        }

        public RefreshBindingScope RefreshBindingScope { get; set; }

        public string Id
        {
            get;
            set;
        }

        [RequiredField]
        [LengthConstraint(250)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    IsDirty = true;
                    NotifyOfPropertyChange(() => Name);
                }
            }
        }

        public void Save()
        {
            RefreshBindingScope.Scope();
            if (this.Validator.HasErrors)
                return;
        }
    }
}
