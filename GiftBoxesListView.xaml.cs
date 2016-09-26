using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class GiftBoxesListView : ContentPage
    {
        public GiftBoxesListView()
        {
            InitializeComponent();

            GiftListView.ItemsSource = new List<TypeCoffee>
            {

                new TypeCoffee
                {
                    Name = "Chocolate Boxes",
                    Price = "$20",
                    ImageUri = "gift.png"

                },
                 new TypeCoffee
                {
                    Name = "Chocolate Boxes",
                    Price = "$20",
                    ImageUri = "gift.png"
                },

                new TypeCoffee
                {
                    Name = "Chocolate Boxes",
                    Price = "$20",
                    ImageUri = "gift.png"
                },

                new TypeCoffee
                {
                    Name = "Chocolate Boxes",
                    Price = "$20",
                    ImageUri = "gift.png"
                },

                 new TypeCoffee
                {
                    Name = "Chocolate Boxes",
                    Price = "$20",
                    ImageUri = "gift.png"
                }

            };
        }
    
    }
}
