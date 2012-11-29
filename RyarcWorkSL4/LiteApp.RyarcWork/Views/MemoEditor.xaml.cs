using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using LiteApp.RyarcWork.ViewModels;

namespace LiteApp.RyarcWork.Views
{
    public partial class MemoEditor : UserControl
    {
        public MemoEditor()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
            NameTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            Name2TextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            return false;
        }
    }
}
