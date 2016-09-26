using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class ProductDetail : ContentPage
    {
      

        public ProductDetail()
        {
            InitializeComponent();
            MainPicker.Items.Add("Heart");
            MainPicker.Items.Add("Rosetta");
            MainPicker.Items.Add("Tulip");
            MainPicker.Items.Add("Free Style");
        }

        

        private async void Bean_Onclicked(object sender, EventArgs e)
        {

            string bean = await DisplayActionSheet("Choose your favourite bean",
                "Arabica",
                "Robusta",
                "Canephora",
                "Jamaica" 
                );
        }

        private async void Milk_Onclicked(object sender, EventArgs e)
        {

            string milk = await DisplayActionSheet("Choose your favourite bean",
                "Lite",
                "Full Cream"
                );
        }

        private void MainSlider_OnValueChanged(object sender, ValueChangedEventArgs e) {
            MainLabel.Text = MainSlider.Value.ToString();
        }


        private void MainPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(name, "Good Choice!", "ok");
        }

        private void Yes_OnClicked(object sender, EventArgs e)
        {
          
        }
    }
}
