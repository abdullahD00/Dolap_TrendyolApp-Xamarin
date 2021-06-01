using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dolap.Users;


namespace Dolap.NavigationPageFolders
    
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageGirisYap : ContentPage
    { 
        public NavigationPageGirisYap()
        {
            InitializeComponent();

           
           
          
            
        }
        
        private async void TrendyolileGirisyap_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new NavigationPageTrendyolGirisYap());
        }

        private async void Facebookilegirisyap_Clicked(object sender, EventArgs e)
        {
           await  Navigation.PushModalAsync(new NavigationPageFacebookGirisYap());
        }

        private async void Girisyapbuton_Clicked(object sender, EventArgs e)
        {
            if (status.Text== "Oturum Açma Başarılı")
            {
                await DisplayAlert("Giriş", "Giriş Yapılıyor...", "Tamam"); 
                await Navigation.PushModalAsync(new NavigationPageAppeGiris());
            }
        }
    }
}