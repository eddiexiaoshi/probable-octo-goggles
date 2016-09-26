using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class ShowChoice : ContentPage
    {

        public ShowChoice()
        {
            InitializeComponent();

          


        CListView.ItemsSource = new List<TypeCoffee>
            {

                new TypeCoffee
                {
                    Name = "Latte",
                    Price = "$4.5",
                    ImageUri = "cof.png"

                },
                 new TypeCoffee
                {
                    Name = "Moka",
                    Price = "$5.5",
                    ImageUri = "cof.png"
                },

                new TypeCoffee
                {
                    Name = "Cappuccino",
                    Price = "$6.5",
                    ImageUri = "cof.png"
                },

                new TypeCoffee
                {
                    Name = "Flat White",
                    Price = "$3.5",
                    ImageUri = "cof.png"
                },

                 new TypeCoffee
                {
                    Name = "Long Black",
                    Price = "$7.5",
                    ImageUri = "cof.png"
                }
             };
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            await Navigation.PushAsync(new ProductDetail());
        }//If click on the cell, will goes into detail page
    }
}
