using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MainViewModel
    {
        public ObservableCollection<ViewItem> ListBoxSource { get; set; }
        public ObservableCollection<ViewItem> TreeViewSource { get; set; }

        public MainViewModel()
        {
            ListBoxSource = new ObservableCollection<ViewItem>();
            TreeViewSource = new ObservableCollection<ViewItem>();

            for (int i = 1; i < 20; i++) ListBoxSource.Add(new ViewItem($"ListBoxItem {i}"));

            ViewItem defaultView = new ViewItem("Root", 1);
            TreeViewSource.Add(defaultView);
            for (int i = 1; i < 10; i++) defaultView.ViewItems.Add(new ViewItem($"TreeViewItem {i}"));
        }
    }
}
