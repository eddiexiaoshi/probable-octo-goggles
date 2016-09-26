using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class HotBeveragesListView : ContentPage
    {
        public HotBeveragesListView()
        {
            InitializeComponent();
     

            HotListView.ItemsSource = new List<TypeCoffee>
            {

                new TypeCoffee
                {
                    Name = "Hot Mugs",
                    Price = "$4.5",
                    ImageUri = "hot.png"

                },
                 new TypeCoffee
                {
                    Name = "Hot Mugs",
                    Price = "$4.5",
                    ImageUri = "hot.png"
                },

                new TypeCoffee
                {
                    Name = "Hot Mugs",
                    Price = "$4.5",
                    ImageUri = "hot.png"
                },

                new TypeCoffee
                {
                    Name = "Hot Mugs",
                    Price = "$4.5",
                    ImageUri = "hot.png"
                },

                 new TypeCoffee
                {
                    Name = "Hot Mugs",
                    Price = "$4.5",
                    ImageUri = "hot.png"
                }

            };
        }
    }
}
