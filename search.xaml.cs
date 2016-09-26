using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class search : ContentPage

    {
        
        private readonly List<string> _names = new List<string>
        {
            "Latte", "Long Black","Flat White", "Chai Latte", "Hot Mugs", "Chocolate Box"
        };

        public search()
        {
            InitializeComponent();
            MainListView.ItemsSource = _names;
        }


        private void MainSearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;
            IEnumerable<string> searchResult = _names.Where(name => name.ToLower().Contains(keyword.ToLower()));
            MainListView.ItemsSource = searchResult;
        }
    }
}
