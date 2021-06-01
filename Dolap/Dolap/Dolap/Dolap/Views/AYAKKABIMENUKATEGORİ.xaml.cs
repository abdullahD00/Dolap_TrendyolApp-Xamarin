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
    public partial class AYAKKABIMENUKATEGORİ : ContentPage
    {
        public AYAKKABIMENUKATEGORİ()
        {
            InitializeComponent();
        }

        private async void sporayakkabi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new SporayakkabıPage()));
        }

        private async void babet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BabetPage()));
        }

        private async void ince_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new İncePage()));
        }

        private  async void topluklu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TopukluPage()));
        }

        private  async void bot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new BotPage()));
        }
    }
}