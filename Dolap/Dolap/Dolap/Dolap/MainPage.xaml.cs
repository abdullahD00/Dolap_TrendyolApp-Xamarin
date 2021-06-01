using Dolap.NavigationPageFolders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Dolap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void AtlaButon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPageAppeGiris());
        }

        private async void TrendyolilegirisyapButon_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new NavigationPageTrendyolGirisYap());
        }

        private  async void FacebookilegirisyapButon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPageFacebookGirisYap());
        }

        private async void GirisyapButon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPageGirisYap());
        }

        private async void UyeolButon_Clicked(object sender, EventArgs e)

        {
            await Navigation.PushModalAsync(new NavigationPageUyeOl());
        }
    }
}
