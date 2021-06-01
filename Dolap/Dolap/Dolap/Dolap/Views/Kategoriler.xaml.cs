using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolap.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Dolap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class Kategoriler : MasterDetailPage

    {
        public Kategoriler()
        {
            InitializeComponent();
            menulist.ItemsSource = getMenuList();
            IsPresented = true;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterPageItem)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = true;
        }

        public List<MasterPageItem> getMenuList()
        {
            var list = new List<MasterPageItem>();


            list.Add(new MasterPageItem()
            {
                title = "erkek",
                targetType = typeof(ERKEKMENUKATEGORİ),
                Icon=ImageSource.FromResource("masterdetailpageerkek.png"),
                Detail="erkek kategoriler"

            }); ;
            list.Add(new MasterPageItem()
            {
                title = "kadın",
                targetType = typeof(KADINMENUKATEGORİ),
                Icon = ImageSource.FromResource("masterdetailpagekadin.png"),
                Detail ="kadın kategoriler"
            }); ;
            list.Add(new MasterPageItem()
            {
                title = "çocuk-bebek",
                targetType = typeof(ÇOCUKBEBEKMENUKATEGORİ),
                Icon = ImageSource.FromResource("masterdetailpagebebekvecocuk.png"),
                Detail ="çocuk,bebek kategori"
            }); ;
            list.Add(new MasterPageItem()
            {
                title = "ayakkabı",
                targetType = typeof(AYAKKABIMENUKATEGORİ),
                   Icon = ImageSource.FromResource("ayakkabikategori.png"),
                Detail ="ayakkabı kategoriler"
            }); ;
            list.Add(new MasterPageItem() 
            {     
                title = "aksesuar",
                targetType = typeof(AKSESUARMENUKATEGORİ),
                 Icon = ImageSource.FromResource("  aksesuar.png"),
                Detail="aksesuar kategori"
            }); ;

            return list;
           
        }
          


    }
}