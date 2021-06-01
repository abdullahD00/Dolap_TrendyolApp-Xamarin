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
    public partial class KADINMENUKATEGORİ : ContentPage
    {
        public KADINMENUKATEGORİ()
        {
            InitializeComponent();
        }

        private async void kadınustgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KadınustgiyimPage()));
        }

        private async void kadınaltgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KadınaltgiyimPage()));
        }

        private  async void kadındısgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KadındısgiyimPage()));
        }

        private  async void kadınplajgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KadınplajgiyimPage()));
        }

        private  async void kadınevgiyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new KadınevgiyimPage()));
        }
    }
}