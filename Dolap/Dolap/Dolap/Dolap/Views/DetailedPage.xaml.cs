using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolap.Views;
using Dolap.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dolap.ViewModels;

namespace Dolap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedPage : ContentPage
    {
        public DetailedPage(AnaSayfaRandomUrunler anaSayfaRandomUrunler)
        {
            InitializeComponent();
            BindingContext = new DetailedPageViewModels(anaSayfaRandomUrunler);
        }
    }
}