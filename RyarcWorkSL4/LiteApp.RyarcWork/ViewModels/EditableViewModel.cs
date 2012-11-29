using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Caliburn.Micro;
using System.ComponentModel;
using LiteApp.RyarcWork.ViewModels.Validation;
using System.ComponentModel.Composition;

namespace LiteApp.RyarcWork.ViewModels
{
    public abstract class EditableViewModel : PropertyChangedBase, IDataErrorInfo
    {
        public EditableViewModel()
        {
            CompositionInitializer.SatisfyImports(this);
        }

        bool _isDirty;
        IValidator _validator;

        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    NotifyOfPropertyChange(() => IsDirty);
                }
            }
        }

        [Import("MemoValidator")]
        public IValidator Validator
        {
            get { return _validator; }
            set
            {
                _validator = value;
                _validator.Target = this;
            }
        }

        public virtual string Error
        {
            get { return null; }
        }

        public virtual string this[string propertyName]
        {
            get
            {
                if (!IsDirty)
                    return null;
                if (Validator == null)
                    return null;
                Validator.Validate();
                return Validator.GetPropertyErrorMessage(propertyName);
            }
        }
    }
}
