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
using LiteApp.RyarcWork.Framework;
using System.Linq;
using Caliburn.Micro;
using System.Collections.Generic;

namespace LiteApp.RyarcWork.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<IWorkspace>, IShell
    {
        [ImportMany]
        public IEnumerable<Lazy<IWorkspace, IWorkspaceMetadata>> Workspaces { get; set; }

        public event EventHandler WorkspaceActivated;

        public void ActivateWorkspace(string name)
        {
            var worksapce = Workspaces.FirstOrDefault(x => x.Metadata.Name == name);
            if (worksapce != null)
            {
                ActivateItem(worksapce.Value);
                if (WorkspaceActivated != null)
                {
                    WorkspaceActivated(this, EventArgs.Empty);
                }
            }
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            ActivateWorkspace("Memos");
        }


    }
}
