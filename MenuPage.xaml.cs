using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using XamarinForms.SQLite.SQLite;

using Xamarin.Forms;
using XamarinForms.SQLite;

namespace Project2
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Search_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new search());
        }

        private async void About_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs());
        }

        private async void Survey_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SQLiteSamplePage().GetSampleContentPage());
        }

        private async void Animation_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Animation());
        }

        private async void Barista_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BeABarista());
        }
    }
}
