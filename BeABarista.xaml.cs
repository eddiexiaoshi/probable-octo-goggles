using Project2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class BeABarista : ContentPage
    {
        public BeABarista()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

    }
}
