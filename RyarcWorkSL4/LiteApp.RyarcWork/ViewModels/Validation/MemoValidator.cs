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
using System.ComponentModel.Composition;

namespace LiteApp.RyarcWork.ViewModels.Validation
{
    [Export("MemoValidator", typeof(IValidator))]
    public class MemoValidator : ValidatorBase
    {
        protected override string ValidateProperty(string propertyName, object value)
        {
            if (propertyName == "Name")
            {
                string name = value as string;
                if (string.IsNullOrWhiteSpace(name))
                    return "Name cannot be empty.";
            }
            return null;
        }
    }
}
