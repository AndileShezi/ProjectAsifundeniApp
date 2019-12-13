using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bashana.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void NumberButton1_Clicked(object sender, EventArgs e)
        {
            await NumberButton1.TranslateTo(20, 20, 500, Easing.BounceOut);
            await NumberButton1.TranslateTo(0, 0);
        }

        async void NumberButton2_Clicked(object sender, EventArgs e)
        {
            await NumberButton2.TranslateTo(20, 20, 500, Easing.BounceOut);
            await NumberButton2.TranslateTo(0, 0);
        }

        async void NumberButton3_Clicked(object sender, EventArgs e)
        {
            await NumberButton3.TranslateTo(20, 20, 500, Easing.BounceOut);
            await NumberButton3.TranslateTo(0, 0);
        }

        private async void NumberButton4_Clicked(object sender, EventArgs e)
        {
            await NumberButton4.ScaleTo(3, 1000);
            await NumberButton4.ScaleTo(1, 1000, Easing.SpringOut);
        }
    }
}