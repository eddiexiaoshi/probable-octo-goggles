using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project2
{
    public partial class Animation : ContentPage
    {
       

        public Animation()
        {
            InitializeComponent();
        }

        

        private async void See_OnClicked(object sender, EventArgs e) {

        
            await MainGrid.TranslateTo(100, 300, 1000, Easing.Linear);
            await MainGrid.RotateTo(90, 800, Easing.SinOut);
            await MainGrid.FadeTo(0.5, 600, Easing.CubicIn);
            await MainGrid.LayoutTo(new Rectangle(-200, -300, 300, 100));
            await MainGrid.ScaleTo(0.6,500,Easing.CubicOut);
        }

        //private void TapGestureRecognizer_OnTapped(object sender, EventArgs e){
          //  BackgroundColor = Color.Red;
            
            //}
    }
}
