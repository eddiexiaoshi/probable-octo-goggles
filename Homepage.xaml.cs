using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
            

        }

        

        private async void Button1_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowChoice());
        }

        private async void Button2_OnClicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new ChocolateListView());
        }

        private async void Button3_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotBeveragesListView());
        }

        private async void Button4_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OtherIndulgencesListView());
        }

        private async void Button5_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GiftBoxesListView());
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            BackgroundColor = Color.Gray;
        }
    }
}
