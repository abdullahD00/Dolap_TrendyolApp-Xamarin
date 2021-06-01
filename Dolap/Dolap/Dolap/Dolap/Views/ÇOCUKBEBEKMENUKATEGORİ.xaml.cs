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
    public partial class ÇOCUKBEBEKMENUKATEGORİ : ContentPage
    {
        public ÇOCUKBEBEKMENUKATEGORİ()
        {
            InitializeComponent();
        }

        private async void bebekustgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BebekustgiyimPage()));
        }

        private async void bebelaltgiyim_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new NavigationPage(new BebekaltgiyimPage()));
        }

        private async void bebekdısgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BebekdısgiyimPage()));
        }

        private async void bebekplajgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BebekplajgiyimPage()));
        }

        private  async void bebekevgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BebekevgiyimPage()));
        }
    }
}