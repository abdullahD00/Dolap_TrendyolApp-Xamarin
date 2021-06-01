using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dolap.ÖdemeEkranıStuff;

namespace Dolap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetPage : ContentPage
    {
        public SepetPage()
        {
            InitializeComponent();
        }

        private async void ödemeyap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Odemeekranianasayfa()));
        }
    }
}