using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ViewItem
    {
        public string ItemName { get; set; }
        public ObservableCollection<ViewItem> ViewItems { get; } = new ObservableCollection<ViewItem>();
        public int IsVisible { get; set; }

        public ViewItem()
        { }

        public ViewItem(string name, int IsVisible = 0)
        {
            this.ItemName = name;
            this.IsVisible = IsVisible;
        }
    }
}
