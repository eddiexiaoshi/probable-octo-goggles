using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class OtherIndulgencesListView : ContentPage
    {
        public OtherIndulgencesListView()
        {
            InitializeComponent();
            OtherListView.ItemsSource = new List<TypeCoffee>
            {

                new TypeCoffee
                {
                    Name = "Pancakes",
                    Price = "$4.5",
                    ImageUri = "other.png"

                },
                 new TypeCoffee
                {
                    Name = "Pancakes",
                    Price = "$4.5",
                    ImageUri = "other.png"
                },

                new TypeCoffee
                {
                    Name = "Pancakes",
                    Price = "$4.5",
                    ImageUri = "other.png"
                },

                new TypeCoffee
                {
                    Name = "Pancakes",
                    Price = "$4.5",
                    ImageUri = "other.png"
                },

                 new TypeCoffee
                {
                    Name = "Pancakes",
                    Price = "$4.5",
                    ImageUri = "other.png"
                }

            };
    }
   }
}
