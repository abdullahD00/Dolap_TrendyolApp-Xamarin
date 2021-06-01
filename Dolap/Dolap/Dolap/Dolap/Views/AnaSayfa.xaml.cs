using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolap.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dolap.Models;
using Dolap.ViewModels;
using System.Collections.ObjectModel;



namespace Dolap.Views
{
  

[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        public IList<AnaSayfaRandomUrunler> AnaSayfaRandoms { get; set; }

        public AnaSayfa()
        {


            InitializeComponent();



            AnaSayfaRandoms = new List<AnaSayfaRandomUrunler>();
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "T-shirt erkek dönme dolap",Fiyat = 40,ImageSource = new Uri("https://ae01.alicdn.com/kf/Ha7574d90fb7445adb283386f9794f4f35/QCIV-marka-ehir-T-shirt-erkek-d-nme-dolap-Tshirt-bask-l-sokak-ti-rtleri-Casual.jpg_q50.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Narnia Aslan Dolap T-shirt",Fiyat = 25,ImageSource = new Uri("https://ae01.alicdn.com/kf/HTB1thS.XebviK0jSZFNq6yApXXa0/Chronicles-Narnia-Aslan-dolap-kolaj-erkek-T-shirt-ti-rt-o-boyun-yaz-ki-ilik-moda.jpg_q50.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Casual kısa kollu Erkek T-shirt",Fiyat = 18,ImageSource = new Uri("https://bolum-sube.today/1_thumb-39246/storage_Moda-bask%C4%B1l%C4%B1-erkek-ti%C5%9F%C3%B6rt-k%C4%B1sa-kollu-stockholm.jpeg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {

                Isim = "Kadın Pantolon Siyah",Fiyat = 55,ImageSource = new Uri("https://www.trendgiysen.com/Uploads/UrunResimleri/buyuk/yuksek-bel-likrali-siyah-bayan-kot-panto-adaf.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Beren Saat Kadın Pantul",Fiyat = 60,ImageSource = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBrv6H0jUZVqRiKCnEhrozEnETY5hm1r-IVqydjmAp62PcwRhpfWtkKYjsiOWbb-DjQWI&usqp=CAU")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Pembe Pantolon Kobal",Fiyat = 35,ImageSource = new Uri("https://img.gecce.com/2017/05/20/sinem-kobal-073930XL.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Aksesuar kadın pembe",Fiyat = 20,ImageSource = new Uri("https://img.letgo.com/images/00/34/ad/b6/0034adb6145fc54ebb4aec04b8b4c39a.jpg?impolicy=img_600_pwa")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Vücudu saran kolye Kadın",Fiyat = 75,ImageSource = new Uri("https://n11scdn.akamaized.net/a1/450/mucevher-saat/vucut-takisi/kadin-aksesuar-vucut-bust-kolyesi-luck-model__0555011108920484.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Kadın siyah dantel detaylı Choker",Fiyat = 50,ImageSource = new Uri("https://cdn.dsmcdn.com/ty53/product/media/images/20210115/12/53594618/126942274/1/1_org.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Erkek Aksesuar Bileklik Harley",Fiyat = 45,ImageSource = new Uri("https://www.taksesuar.com/Uploads/UrunResimleri/thumb/kuru-kafa-ve-yildiz-tasarim-kayisli-deri-c46a.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Erkek yüzük ay yıldızlı",Fiyat = 65,ImageSource = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScqULvylhF790rC-QpxjZnkeUCGxPmDQa7ig&usqp=CAU")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Erkek Kemer siyah", Fiyat = 28,ImageSource = new Uri("https://img-morhipo.mncdn.com/mnresize/378/518/productimages/i/2850001722139/[img][4][1].jpg?1915")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Renkli Saldalyeler renkli",Fiyat = 250,ImageSource = new Uri("https://www.mtoraman.com/images/urunler/Sandalye-Army-Plastik--resim-628.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Mutfak Hasır supla",Fiyat = 120,ImageSource = new Uri("https://cdn.dsmcdn.com/mnresize/415/622/ty16/product/media/images/20210323/12/74629934/156469428/1/1_org_zoom.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Ev Dekoratif süs eşyası",Fiyat = 59,ImageSource = new Uri("https://cdn.dsmcdn.com/ty85/product/media/images/20210315/22/71838112/152759168/0/0_org.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Ev az kullanılmış ampul",Fiyat = 25,ImageSource = new Uri("https://www.e-alkan.com/philips-economy-twister-23w-ww-e27-220-240v-1pf6-929689220601-tasarruflu-ampul-philips-21-44-B.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Ev terliği 12 yıllık",Fiyat = 250,ImageSource = new Uri("https://cdn-mgsm.akinon.net/products/2020/05/19/78181/ed4c1a42-fc9c-42f0-85a7-c083ee8a620e_size437x330_cropCenter.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Kapı Askılığı Ev",Fiyat = 12,ImageSource = new Uri("https://www.uydutoptan.com/Uploads/UrunResimleri/thumb/homecare-her-kapiya-uygun-kapi-arkasi-me-2dc5.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Erkek bebek giyim seti Sarı",Fiyat = 95,ImageSource = new Uri("https://www.dhresource.com/0x0/f2/albu/g1/M00/36/2F/rBVaGFoS89uALPHsAAQqQ4rkZao583.jpg/2018-newest-cute-newborn-baby-clothing-suit.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "3'lü Erkek çocuk set",Fiyat = 80,ImageSource = new Uri("https://productimages.hepsiburada.net/l/35/600-800/10484219805746.jpg")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Kız çocuk giyim çizgili",Fiyat = 60,ImageSource = new Uri("https://img.letgo.com/images/25/97/d0/50/2597d0507f21160473c9a118ef1aed5b.jpeg?impolicy=img_600_pwa")
            });
            AnaSayfaRandoms.Add(new AnaSayfaRandomUrunler
            {
                Isim = "Sarı kare yaka Ekose kısa kollu elbise Kız çocuk",Fiyat = 120,ImageSource = new Uri("https://image.dhgate.com/0x0s/f2-albu-g10-M00-D7-F7-rBVaWV7LguaAOY8hAAD6JL5Pud4491.jpg/yaz-yeni-stil-k-z-elbise-yazl-k-elbise-yeni.jpg")
            });



            BindingContext = this;



        }

        async  private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AnaSayfaRandomUrunler anaSayfaRandomUrunler = ((CollectionView)sender).SelectedItem as AnaSayfaRandomUrunler;
            if (anaSayfaRandomUrunler==null)
            {
                return;
            }
            else
            {

                await Navigation.PushAsync(new NavigationPage(new DetailedPage(anaSayfaRandomUrunler)));
                
            }
        }

        private void searchbararama_TextChanged(object sender, TextChangedEventArgs e)
        {

            var searchResult = AnaSayfaRandoms.Where(c => c.Isim.ToLower().Contains(searchbararama.Text.ToLower()));
            coll2.ItemsSource = searchResult;

        }
    }
}