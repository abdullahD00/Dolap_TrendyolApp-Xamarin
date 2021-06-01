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
    public partial class NavigationPageUyeOl : ContentPage
    {
        public NavigationPageUyeOl()
        {
            InitializeComponent();
        }

        private async void TrendyolileGirisyap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPageTrendyolGirisYap());
        }

        private async void Facebookilegirisyap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPageFacebookGirisYap());
        }

        private async void Uyeolbuton_Clicked(object sender, EventArgs e)
        {
            if (üyelikradiobutton.IsChecked==true)
            {
               

               

                await DisplayAlert("KAYIT", "Kaydınız oluşturuldu", "Tamam");
                await Navigation.PushModalAsync(new MainPage());

            }
            else 
            {
                await DisplayAlert("UYARI", "Tüm bilgileri  doldurup Kullanıcı Sözleşmesi kutucuğunu doldurduğunuzdan emin olun!", "Tamam");
            }
        }
    }
}