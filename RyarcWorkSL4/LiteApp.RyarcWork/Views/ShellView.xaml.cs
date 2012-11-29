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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Caliburn.Micro;
using LiteApp.RyarcWork.Framework;
using LiteApp.RyarcWork.ViewModels;

namespace LiteApp.RyarcWork.Views
{
    public partial class ShellView : UserControl
    {
        ShellViewModel _shell;

        public ShellView()
        {
            InitializeComponent();
            this.DataContextChanged += ShellView_DataContextChanged;
            this.LayoutUpdated += ShellView_LayoutUpdated;
        }

        void ShellView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _shell = e.NewValue as ShellViewModel;
            _shell.WorkspaceActivated += _shell_WorkspaceActivated;
        }


        void ShellView_LayoutUpdated(object sender, EventArgs e)
        {
            UpdateLinkStates();
        }

        void _shell_WorkspaceActivated(object sender, EventArgs e)
        {
            UpdateLinkStates();
        }

        void UpdateLinkStates()
        {
            var activeWorkspaceName = _shell.ActiveItem.Name;
            foreach (UIElement child in LinksStackPanel.Children)
            {
                HyperlinkButton hb = child as HyperlinkButton;
                if (hb != null)
                {
                    if (hb.Tag as string == activeWorkspaceName)
                    {
                        VisualStateManager.GoToState(hb, "ActiveLink", true);
                    }
                    else
                    {
                        VisualStateManager.GoToState(hb, "InactiveLink", true);
                    }
                }
            }
        }

    }
}