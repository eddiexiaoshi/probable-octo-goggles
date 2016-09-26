using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class ChocolateListView : ContentPage
    {
        public ChocolateListView()
        {
            InitializeComponent();


            CoListView.ItemsSource = new List<TypeCoffee>
            {

                new TypeCoffee
                {
                    Name = "Fruits with Chocolate",
                    Price = "$4.5",
                    ImageUri = "cho.png"

                },
                 new TypeCoffee
                {
                    Name = "Fruits with Chocolate",
                    Price = "$4.5",
                    ImageUri = "cho.png"
                },

                new TypeCoffee
                {
                    Name = "Fruits with Chocolate",
                    Price = "$4.5",
                    ImageUri = "cho.png"
                },

                new TypeCoffee
                {
                    Name = "Fruits with Chocolate",
                    Price = "$4.5",
                    ImageUri = "cho.png"
                },

                 new TypeCoffee
                {
                    Name = "Fruits with Chocolate",
                    Price = "$4.5",
                    ImageUri = "cho.png"
                }

            };
        }
    }
}
