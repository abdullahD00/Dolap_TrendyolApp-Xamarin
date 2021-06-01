using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dolap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ERKEKMENUKATEGORİ : ContentPage
    {
        public ERKEKMENUKATEGORİ()
        {
            InitializeComponent();
        }

        private async void erkekustgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ErkekustgiyimPage()));
        }

        private async void erkekaltgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ErkekaltgiyimPage()));
        }

        private async void erkekdısgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ErkekdısgiyimPage()));
        }

        private async void erkekplajgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ErkekplajgiyimPage()));
        }

        private async void erkekevgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ErkekevgiyimPage()));
        }
    }
}