using Dolap.Models;
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
    public partial class SapkaPage : ContentPage
    {
        public SapkaPage()
        {
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AnaSayfaRandomUrunler anaSayfaRandomUrunler = ((CollectionView)sender).SelectedItem as AnaSayfaRandomUrunler;
            if (anaSayfaRandomUrunler == null)
            {
                return;
            }
            else
            {

                await Navigation.PushAsync(new NavigationPage(new DetailedPage(anaSayfaRandomUrunler)));

            }
        }
    }
}