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
using LiteApp.RyarcWork.Framework;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using System.Linq;
using LiteApp.RyarcWork.Services.Memo;

namespace LiteApp.RyarcWork.ViewModels
{
    [Export(typeof(IWorkspace))]
    [ExportMetadata("Name", "Memos")]
    public class MemosWorkspaceViewModel : Screen, IWorkspace
    {
        BindableCollection<MemoViewModel> _items;
        bool _isBusy;

        public string Name
        {
            get { return "Memos"; }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            private set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    NotifyOfPropertyChange(() => IsBusy);
                }
            }
        }

        public IEnumerable<MemoViewModel> Items
        {
            get
            {
                if (_items == null)
                {
                    Load();
                }
                return _items;
            }
        }

        public void AddMemo()
        {
            var model = new MemoViewModel();
            IoC.Get<IWindowManager>().ShowDialog(model);
        }

        void Load()
        {
            MemoServiceClient client = new MemoServiceClient();
            client.GetMemosCompleted += (sender, e) =>
                {
                    if (e.Error == null)
                    {
                        _items = new BindableCollection<MemoViewModel>(e.Result.Select(x => MapToMemoViewModel(x)));
                        NotifyOfPropertyChange(() => Items);
                        IsBusy = false;
                    }
                };
            client.GetMemosAsync();
            IsBusy = true;
        }

        MemoViewModel MapToMemoViewModel(Memo m)
        {
            MemoViewModel model = new MemoViewModel();
            model.Id = m.Id.ToString();
            m.Name = m.Name;
            return model;
        }
    }
}
