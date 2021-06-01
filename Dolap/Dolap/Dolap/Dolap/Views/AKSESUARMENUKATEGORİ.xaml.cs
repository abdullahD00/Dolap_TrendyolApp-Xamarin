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
    public partial class AKSESUARMENUKATEGORİ : ContentPage
    {
        public AKSESUARMENUKATEGORİ()
        {
            InitializeComponent();
        }

        private async void gozluk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new GozlukPage()));
        }

        private async void saat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new SaatPage()));
        }

        private  async void takı_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TakıPage()));
        }

        private  async void kemer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KemerPage()));
        }

        private async void sapka_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new SapkaPage()));
        }
    }
}