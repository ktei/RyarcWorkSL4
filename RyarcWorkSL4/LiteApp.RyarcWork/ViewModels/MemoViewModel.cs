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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LiteApp.RyarcWork.ViewModels.Validation;

namespace LiteApp.RyarcWork.ViewModels
{
    public class MemoViewModel : EditableViewModel, IDataErrorInfo
    {
        string _name;

        public string Id
        {
            get;
            set;
        }

        [ValidationRequired]
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
    }
}
