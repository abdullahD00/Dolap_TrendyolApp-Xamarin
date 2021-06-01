using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Dolap.Models;
namespace Dolap.ViewModels
{
    public class AnaSayfaRandomUrunlerViewModels
    {
        ObservableCollection<AnaSayfaRandomUrunler> anaSayfaRandomUrunlers;


        ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekust;
        ObservableCollection<AnaSayfaRandomUrunler> kategorierkekalt;
        ObservableCollection<AnaSayfaRandomUrunler> kategorierkekdışgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorierkekplaj;
        ObservableCollection<AnaSayfaRandomUrunler> kategorierkekevgiyim;


        ObservableCollection<AnaSayfaRandomUrunler> kategorikadınustgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikadınaltgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikadınelbisegiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikadındısgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikadınplajgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikadınevgiyim;


        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekustgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekaltgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekelbise;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekdısgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekplajgiyim;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribebekevgiyim;


        ObservableCollection<AnaSayfaRandomUrunler> kategoriayakkabıspor;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribabet;
        ObservableCollection<AnaSayfaRandomUrunler> kategoriince;
        ObservableCollection<AnaSayfaRandomUrunler> kategoritopuklu;
        ObservableCollection<AnaSayfaRandomUrunler> kategoribot;

        ObservableCollection<AnaSayfaRandomUrunler> kategorigozluk;
        ObservableCollection<AnaSayfaRandomUrunler> kategorisaat;
        ObservableCollection<AnaSayfaRandomUrunler> kategoritakı;
        ObservableCollection<AnaSayfaRandomUrunler> kategorikemer;
        ObservableCollection<AnaSayfaRandomUrunler> kategorisapka;

        public AnaSayfaRandomUrunlerViewModels()
        {
            AnaSayfaRandomUrunlers = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="T-shirt erkek dönme dolap",
                                          Fiyat=40,
                                          ImageSource=new Uri("https://ae01.alicdn.com/kf/Ha7574d90fb7445adb283386f9794f4f35/QCIV-marka-ehir-T-shirt-erkek-d-nme-dolap-Tshirt-bask-l-sokak-ti-rtleri-Casual.jpg_q50.jpg")},
                new AnaSayfaRandomUrunler{Isim="Narnia Aslan Dolap T-shirt",
                                          Fiyat=25,
                                          ImageSource=new Uri("https://ae01.alicdn.com/kf/HTB1thS.XebviK0jSZFNq6yApXXa0/Chronicles-Narnia-Aslan-dolap-kolaj-erkek-T-shirt-ti-rt-o-boyun-yaz-ki-ilik-moda.jpg_q50.jpg")},
                new AnaSayfaRandomUrunler{Isim="Casual kısa kollu Erkek T-shirt",
                                          Fiyat=18,
                                          ImageSource=new Uri("https://bolum-sube.today/1_thumb-39246/storage_Moda-bask%C4%B1l%C4%B1-erkek-ti%C5%9F%C3%B6rt-k%C4%B1sa-kollu-stockholm.jpeg")},
                new AnaSayfaRandomUrunler{Isim="Kadın Pantolon Siyah",
                                          Fiyat=55,
                                          ImageSource=new Uri("https://www.trendgiysen.com/Uploads/UrunResimleri/buyuk/yuksek-bel-likrali-siyah-bayan-kot-panto-adaf.jpg")},
                new AnaSayfaRandomUrunler{Isim="Beren Saat Kadın Pantul",
                                          Fiyat=60,
                                          ImageSource=new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBrv6H0jUZVqRiKCnEhrozEnETY5hm1r-IVqydjmAp62PcwRhpfWtkKYjsiOWbb-DjQWI&usqp=CAU")},
                new AnaSayfaRandomUrunler{Isim="Pembe Pantolon Kobal",
                                          Fiyat=35,
                                          ImageSource=new Uri("https://img.gecce.com/2017/05/20/sinem-kobal-073930XL.jpg")},
                new AnaSayfaRandomUrunler{Isim="Aksesuar kadın pembe",
                                          Fiyat=20,
                                          ImageSource=new Uri("https://img.letgo.com/images/00/34/ad/b6/0034adb6145fc54ebb4aec04b8b4c39a.jpg?impolicy=img_600_pwa")},
                new AnaSayfaRandomUrunler{Isim="Vücudu saran kolye Kadın",
                                          Fiyat=75,
                                          ImageSource=new Uri("https://n11scdn.akamaized.net/a1/450/mucevher-saat/vucut-takisi/kadin-aksesuar-vucut-bust-kolyesi-luck-model__0555011108920484.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kadın siyah dantel detaylı Choker",
                                          Fiyat=50,
                                          ImageSource=new Uri("https://cdn.dsmcdn.com/ty53/product/media/images/20210115/12/53594618/126942274/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="Erkek Aksesuar Bileklik Harley",
                                          Fiyat=45,
                                          ImageSource=new Uri("https://www.taksesuar.com/Uploads/UrunResimleri/thumb/kuru-kafa-ve-yildiz-tasarim-kayisli-deri-c46a.jpg")},
                new AnaSayfaRandomUrunler{Isim="Erkek yüzük ay yıldızlı",
                                          Fiyat=65,
                                          ImageSource=new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScqULvylhF790rC-QpxjZnkeUCGxPmDQa7ig&usqp=CAU")},
                new AnaSayfaRandomUrunler{Isim="Erkek Kemer siyah",
                                          Fiyat=28,
                                          ImageSource=new Uri("https://img-morhipo.mncdn.com/mnresize/378/518/productimages/i/2850001722139/[img][4][1].jpg?1915")},
                new AnaSayfaRandomUrunler{Isim="Renkli Saldalyeler renkli",
                                          Fiyat=250,
                                          ImageSource=new Uri("https://www.mtoraman.com/images/urunler/Sandalye-Army-Plastik--resim-628.jpg")},
                new AnaSayfaRandomUrunler{Isim="Mutfak Hasır supla",
                                          Fiyat=120,
                                          ImageSource=new Uri("https://cdn.dsmcdn.com/mnresize/415/622/ty16/product/media/images/20210323/12/74629934/156469428/1/1_org_zoom.jpg")},
                new AnaSayfaRandomUrunler{Isim="Ev Dekoratif süs eşyası",
                                          Fiyat=59,
                                          ImageSource=new Uri("https://cdn.dsmcdn.com/ty85/product/media/images/20210315/22/71838112/152759168/0/0_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="Ev az kullanılmış ampul",
                                          Fiyat=25,
                                          ImageSource=new Uri("https://www.e-alkan.com/philips-economy-twister-23w-ww-e27-220-240v-1pf6-929689220601-tasarruflu-ampul-philips-21-44-B.jpg")},
                new AnaSayfaRandomUrunler{Isim="Ev terliği 12 yıllık",
                                          Fiyat=250,
                                          ImageSource=new Uri("https://cdn-mgsm.akinon.net/products/2020/05/19/78181/ed4c1a42-fc9c-42f0-85a7-c083ee8a620e_size437x330_cropCenter.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kapı Askılığı Ev",
                                          Fiyat=12,
                                          ImageSource=new Uri("https://www.uydutoptan.com/Uploads/UrunResimleri/thumb/homecare-her-kapiya-uygun-kapi-arkasi-me-2dc5.jpg")},
                new AnaSayfaRandomUrunler{Isim="Erkek bebek giyim seti Sarı",
                                          Fiyat=95,
                                          ImageSource=new Uri("https://www.dhresource.com/0x0/f2/albu/g1/M00/36/2F/rBVaGFoS89uALPHsAAQqQ4rkZao583.jpg/2018-newest-cute-newborn-baby-clothing-suit.jpg")},
                new AnaSayfaRandomUrunler{Isim="3'lü Erkek çocuk set",
                                           Fiyat=80,
                                         ImageSource=new Uri("https://productimages.hepsiburada.net/l/35/600-800/10484219805746.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kız çocuk giyim çizgili",
                                          Fiyat=60,
                                          ImageSource=new Uri("https://img.letgo.com/images/25/97/d0/50/2597d0507f21160473c9a118ef1aed5b.jpeg?impolicy=img_600_pwa")},
                new AnaSayfaRandomUrunler{Isim="Sarı kare yaka Ekose kısa kollu elbise Kız çocuk",
                                          Fiyat=120,
                                          ImageSource=new Uri("https://image.dhgate.com/0x0s/f2-albu-g10-M00-D7-F7-rBVaWV7LguaAOY8hAAD6JL5Pud4491.jpg/yaz-yeni-stil-k-z-elbise-yazl-k-elbise-yeni.jpg")}
            };

            Kategorierkekust = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="baskılı erkek tshirt", Fiyat=35,ImageSource=new Uri("https://i.pinimg.com/originals/82/5a/f5/825af5526633c07f4ebdb3cd12bb0901.jpg") },
                new AnaSayfaRandomUrunler{Isim="jean kot gömlek", Fiyat=120,ImageSource=new Uri("https://deepsea.com.tr/162118-home_default/deepsea-erkek-oenue-cepli-citcitli-kapsonlu-lykrali-kot-goemlek-2103451.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek kırmızı kazak",Fiyat=50,ImageSource=new Uri("https://www.bessmoon.com/Uploads/UrunResimleri/thumb/erkek-bordo-yarim-balikci-kazak-regula-778-89.jpeg")},
                new AnaSayfaRandomUrunler{Isim="erkek gabardin kürklü mont	",Fiyat=250,ImageSource=new Uri("http://www.madmext.com/Uploads/UrunResimleri/buyuk/madmext-gabardin-kurklu-erkek-mont-m-66-c63e.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek takım elbise",Fiyat=350,ImageSource=new Uri("https://static.tvtropes.org/pmwiki/pub/images/ezel_4.jpg")},
                new AnaSayfaRandomUrunler{Isim="erdal bakkal beyaz önlük",Fiyat=80,ImageSource=new Uri("https://spotdergi.files.wordpress.com/2012/06/img_5231.jpg")}
            };

            Kategorierkekalt = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="erkek alt eşofman gri",Fiyat=45,ImageSource=new Uri("http://www.mylifemoda.com/Uploads/UrunResimleri/buyuk/erkek-alt-esofman-gri-6857.jpg")},
                new AnaSayfaRandomUrunler{Isim="lastikli paça eşofman", Fiyat=60,ImageSource=new Uri("https://www.zgiyim.com.tr/Uploads/UrunResimleri/Thumb/erkek--siyah--beli-ve-paca-lastikli-te-8a-ac0.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadife pantalon",Fiyat=70,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/1500/1969/product-images/8KAM41880LW082/1500Wx1969H/8KAM41880LW082_G03_zoom3_V02.jpg")},
                new AnaSayfaRandomUrunler{Isim="kareli pantalon", Fiyat=85,ImageSource=new Uri("https://cdn.dsmcdn.com//ty61/product/media/images/20210122/11/56083491/77013557/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek pantalon ispanyol paça",Fiyat=90,ImageSource=new Uri("https://img-s1.onedio.com/id-561281a91ceeb9687fdcb08e/rev-0/w-500/s-d4caf1e137335943014fc665b997783c29863dbe.jpg")}
            };

            Kategorierkekdışgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="spor erkek", Fiyat=65,ImageSource=new Uri("https://erkekgiyim.wessi.com/wp-content/uploads/2020/01/erkek-sportif-giyim-%C3%B6nerileri.jpg")},
                new AnaSayfaRandomUrunler{Isim="siyah mont", Fiyat=250,ImageSource=new Uri("https://cdn.markastok.com/buratti-cikarilabilir-kapusonlu-ekstra-slim-fit-erkek-mont-556b5050-siyah-7762164-77-O.jpg")},
                new AnaSayfaRandomUrunler{Isim="kırmızı şişme mont erkek", Fiyat=270,ImageSource=new Uri("https://i.pinimg.com/originals/2a/c7/a9/2ac7a93b167821a2e794ec7108e0cfb6.jpg")},
                new AnaSayfaRandomUrunler{Isim="kaşmir erkek dış giyim", Fiyat=200,ImageSource=new Uri("https://www.gobi.com.tr/image/cache/catalog/StokResim/Erkek/4-MS-1320002Z-150-927-765x1100.jpg")},
                new AnaSayfaRandomUrunler{Isim="kamuflaj ceket",Fiyat=180,ImageSource=new Uri("https://alisveris-outlet.cam/pics/1_182082/picture_Art%C4%B1-6xl-7xl-erkek-kamuflaj-ceket-erkek-rahat-ceket.jpeg")}
            };
            Kategorierkekplaj = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="erkek renkli plaj model",Fiyat=50,ImageSource=new Uri("https://cdn.dsmcdn.com//ty67/product/media/images/20210204/9/59842259/17977655/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="yeni sezon DAGİ model", Fiyat=120,ImageSource=new Uri("https://www.dagi.com.tr/productimages/124158/big/e0620y0019_mrelc1.jpg")},
                new AnaSayfaRandomUrunler{Isim="dorense erkek mayo",Fiyat=80,ImageSource=new Uri("https://www.galiyet.com/Uploads/UrunResimleri/thumb/doreanse-erkek-sort-mayo-3806-2cbb.jpg")},
                new AnaSayfaRandomUrunler{Isim="alevli short meşhur",Fiyat=100,ImageSource=new Uri("https://galeri8.uludagsozluk.com/466/alevli-deniz-%C5%9Fortu_558403.jpg")},
                new AnaSayfaRandomUrunler{Isim="koton ürün modeli erkek plaj",Fiyat=50,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/406/534/product-images/0YAM49058GWQ16/1500Wx1969H/0YAM49058GWQ16_G01_zoom1_V01.jpg")}
            };
            Kategorierkekevgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="goldenbay erkek ev giyimi", Fiyat=160,ImageSource=new Uri("https://content.icgiyimozel.com/images/urun/orta/goldenbay-erkek-ev-giyimi-4006-kahverengi-59229.jpg")},
                new AnaSayfaRandomUrunler{Isim="pijama takımı",Fiyat=150,ImageSource=new Uri("https://www.kom.com.tr/media/catalog/product/cache/1/small_image/400x/040ec09b1e35df139433887a97daa66f/1/u/1u11cpey201.003.c00121_1.jpg")},
                new AnaSayfaRandomUrunler{Isim="ev pijama takımı", Fiyat=80,ImageSource=new Uri("https://icdn.ensonhaber.com/resimler/galeri/1_12336.jpg")},
                new AnaSayfaRandomUrunler{Isim="takım giyim modeli",Fiyat=100,ImageSource=new Uri("https://indigodergisi.com/wp-content/uploads/2019/11/erkek-pijama-ic-camasiri-giyim-modelleri.jpg")},
                new AnaSayfaRandomUrunler{Isim="Grımelanj takım",Fiyat=130,ImageSource=new Uri("https://cdn.arnetta.com.tr/arnetta-baba-ogul-uzun-kolerkek-pijama-takim-grimelanj-pijama-takimi-arnetta-2020-k-22588-24-B.jpg")}
            };

            //kadın kategorileri başlangıç


            Kategorikadınustgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kadın üst giyim küboş",Fiyat=100,ImageSource=new Uri("https://www.kubos.com.tr/Uploads/UrunResimleri/thumb/balikci-triko-bodysuit---camel-da5c.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadın hardal kare yakalı",Fiyat=120, ImageSource=new Uri("https://www.kadinmodasi.com/Uploads/UrunResimleri/Thumb/kadin-hardal-kare-yaka-gipeli-etegi-ba-8c6ee5.jpg")},
                new AnaSayfaRandomUrunler{Isim="desenli siyah elbise", Fiyat=80,ImageSource=new Uri("https://tr.web.img2.acsta.net/r_1280_720/pictures/17/09/13/20/12/0708743.jpg")},
                new AnaSayfaRandomUrunler{Isim="beyaz elbise üst giyim", Fiyat=75,ImageSource=new Uri("https://i.tmgrup.com.tr/vogue/original/15-08/14/jennifer_lawrence_5_neden_kapak-1439553035.jpg")},
                new AnaSayfaRandomUrunler{Isim="siyah üst giyim", Fiyat=60,ImageSource=new Uri("https://img.tele1.com.tr/wp-content/uploads/2020/07/Untitled-1-33-690x450.jpg")}
            };

            Kategorikadınaltgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="zafoni ürün alt giyim",Fiyat=85,ImageSource=new Uri("https://www.zafoni.com/i/m/005/0050621_bel-kusakli-klasik-pantolon.jpeg")},
                new AnaSayfaRandomUrunler{Isim="alt giyim renkli",Fiyat=50,ImageSource=new Uri("https://www.kadinmodasi.com/Uploads/UrunResimleri/thumb/kadin-pembe-lastikli-beli-baglamali-da-453f-a.jpg")},
                new AnaSayfaRandomUrunler{Isim="beli lastikli tayt",Fiyat=80,ImageSource=new Uri("https://cdn.sorsware.com/alvina/ContentImages/Product/2018-yili-kis/18KPNT007276-001/7276-6775-tayt-pantolon-36-44-tek40_siyah-siyah_1_659x985.JPG")},
                new AnaSayfaRandomUrunler{Isim="siyah desenli dokuma",Fiyat=30,ImageSource=new Uri("https://cdn.sorsware.com/jimmykey/ContentImages/Product/2019yaz/JK19YKDK047033/desenli-dokuma-pantolon_siyah-900-siyah_1_614x805.jpg")},
                new AnaSayfaRandomUrunler{Isim="italyan pantalon",Fiyat=100,ImageSource=new Uri("https://puafashion.com/img/s/3/pantolon-mavi-pacasi-yazili-likrali-pantolon-13970.jpg")}
            };

            Kategorikadınelbisegiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="çiçek desenli yarım düğmeli elbise",Fiyat=150,ImageSource=new Uri("https://cdn.sementa.com/cicek-desenli-yarim-dugmeli-kadin-elbise-mercan-elbise-sementa-31850-11-K.jpg")},
                new AnaSayfaRandomUrunler{Isim="New laviva desenli uzun gömlek elbise",Fiyat=100,ImageSource=new Uri("https://productimages.hepsiburada.net/l/32/600-800/10385624432690.jpg")},
                new AnaSayfaRandomUrunler{Isim="Colin's kadın elbise",Fiyat=250,ImageSource=new Uri("https://img-colinstr.mncdn.com/Assets/Branch/Thumbs/kadn_elbise_122384.jpeg")},
                new AnaSayfaRandomUrunler{Isim="Nervür detaylı poplin kadın elbise",Fiyat=180,ImageSource=new Uri("https://www.vivencia.com.tr/Uploads/UrunResimleri/Thumb/vivencianervur-detayli-poplin-kadin-el-ce3967.jpg")},
                new AnaSayfaRandomUrunler{Isim="Önü büzgülü çiçekli elbise",Fiyat=110,ImageSource=new Uri("https://www.mooibutik.com/onu-buzgulu-cicekli-elbise-siyah-elbise-mooi-butik-4729-11-B.jpg")}
            };

            Kategorikadındısgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kadın dış giyim mavi ceket",Fiyat=80,ImageSource=new Uri("https://www.kadinmodasi.com/Uploads/UrunResimleri/thumb/kadin-mavi-yakali-dort-dugmeli-fleto-c-b240df.jpg")},
                new AnaSayfaRandomUrunler{Isim="mavi kot ceket",Fiyat=40,ImageSource=new Uri("https://cdn-gap.akinon.net/products/2021/02/16/244001/05bff79c-6c50-4995-877c-ddaf4520204d_size360x480_cropCenter.jpg")},
                new AnaSayfaRandomUrunler{Isim="gri deri ceket kadın",Fiyat=200,ImageSource=new Uri("https://globaldukkan.co/22247-1-large_default/2018-yeni-bahar-kad%C4%B1n-d%C4%B1%C5%9F-giyim-siyah-gri-pu-ceket-iki-b%C3%BCy%C3%BCk-cepler-kap%C3%BC%C5%9Fonlu-rahat-k%C4%B1sa-motosiklet-ceket-marka-kad%C4%B1n-coat.jpg")},
                new AnaSayfaRandomUrunler{Isim="kahverengi şişme mont",Fiyat=120,ImageSource=new Uri("https://cdn.markastok.com/lela-dik-yaka-fermuarli-sisme-bayan-yelek-497yaprak-hardal-7783414-87-K.jpg")},
                new AnaSayfaRandomUrunler{Isim="kırmızı ceket",Fiyat=50,ImageSource=new Uri("https://emporium-taze.today/1-Moda-ofis-bayanlar-beyaz-blazers-kad%C4%B1n-d%C4%B1%C5%9F-giyim_91590/content-images.jpeg")}

            };

            Kategorikadınplajgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="peschtemall plaj elbise kadın giyim",Fiyat=50,ImageSource=new Uri("https://images-na.ssl-images-amazon.com/images/I/41XikZzVF2L._AC_SY780_.jpg")},
                new AnaSayfaRandomUrunler{Isim="kırmızı bikini plaj",Fiyat=70,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/406/534/product-images/1YAK88109BM514/1500Wx1969H/1YAK88109BM514_G01_zoom1_V01.jpg")},
                new AnaSayfaRandomUrunler{Isim="yaprak desenli plaj ",Fiyat=100,ImageSource=new Uri("https://img-penti.mncdn.com/INTERSHOP/static/WFS/Penti-PentiChannel-Site/mobile/Penti/tr_TR/M/PLGESRPD21IY-MIX_front_71AB3E3BBAECCFE2A31616711163216780.jpg")},
                new AnaSayfaRandomUrunler{Isim="yeşil bikini kadın plaj",Fiyat=80,ImageSource=new Uri("https://img-penti.mncdn.com/INTERSHOP/static/WFS/Penti-PentiChannel-Site/mobile/Penti/tr_TR/M/PLYCBYOE21IY-STR_front_2BD78A984B99DB45011617054131579464.jpg")},
                new AnaSayfaRandomUrunler{Isim="turuncu elbise plaj giyim",Fiyat=50,ImageSource=new Uri("https://dfcdn.defacto.com.tr/480/S5063AZ_20SM_BN60_01_01.jpg")}
            };

            Kategorikadınevgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="gri eşofman takımı ev giyim",Fiyat=50,ImageSource=new Uri("https://www.pijamaicgiyim.com/images/thumbs/0001816_penye-mood-8445-bayan-ev-giyim_600.jpeg")},
                new AnaSayfaRandomUrunler{Isim="ev giyim kadın",Fiyat=90,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/406/534/product-images/1YLK34297MK344/1500Wx1969H/1YLK34297MK344_G01_zoom1_V01.jpg")},
                new AnaSayfaRandomUrunler{Isim="desenli eşofman takımı kadın ev giyim",Fiyat=110,ImageSource=new Uri("https://img-morhipo.mncdn.com/mnresize/378/518/productimages/i/7894561260477/[img][4][1].jpg?2319")},
                new AnaSayfaRandomUrunler{Isim="kaktüs desenli ev giyim kadın ",Fiyat=70,ImageSource=new Uri("https://ae01.alicdn.com/kf/HTB1TuHcXdzvK1RkSnfoq6zMwVXaP/Bahar-kakt-s-bask-pijama-seti-uzun-kollu-kad-n-ev-giyim-kad-n-rme-pamuk.jpg_Q90.jpg_.webp")},
                new AnaSayfaRandomUrunler{Isim="çiçek desenli ev giyim ",Fiyat=120,ImageSource=new Uri("https://content.icgiyimozel.com/images/urun2020/liste/yaz-pijama-loungewear-nbb-66661-yesil-128210.jpg")}
            };

            //bebek ve cocuk kategoriler

            Kategoribebekustgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kız çocuk üst giyim ",Fiyat=50,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/406/534/product-images/1YKG17425OKKRM/1500Wx1969H/1YKG17425OKKRM_G01_zoom1_V01.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek çocuk üst giyim",Fiyat=70,ImageSource=new Uri("https://www.breezewholesaletr.com/Uploads/UrunResimleri/thumb/breeze-erkek-cocuk-uzun-kollu-tisort-c-fd-bc9.jpg")},
                new AnaSayfaRandomUrunler{Isim="gökkuşağı tsihrt kız üst giyim",Fiyat=90,ImageSource=new Uri("https://www.tchibo.com.tr/newmedia/page/img/b2d9b14cdefa20bf/image_match_jpg.jpg")},
                new AnaSayfaRandomUrunler{Isim="lacoste erkek çocuk giyim ",Fiyat=40,ImageSource= new Uri("https://laco.akinoncdn.com/cms/2020/12/18/e83a2d63-1235-409e-86b5-960408fb8c52.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız çocuk giyim mont",Fiyat=110,ImageSource=new Uri("https://www6.istanbulmuzakereleri.org/16551-1-large_default/Benemaker-2019-Sonbahar-Uzun-Kollu-Sweatshirt-K%C4%B1z-Toddler-Rahat-%C3%A7ocuk-Hoodies-Giyim-Bebek-%C3%A7ocuklar-%C3%BCst-giyim-I%C3%A7in-Giysi-JH118.jpg")}
            };

            Kategoribebekaltgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kız çocuk alt giyim",Fiyat=50,ImageSource=new Uri("https://www.breeze.com.tr/Uploads/UrunResimleri/thumb/breeze-kiz-cocuk-kot-pantolon-beli-las-9e7e7e.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek çocuk kapri siyah",Fiyat=90,ImageSource=new Uri("https://i.pinimg.com/originals/b7/55/ad/b755adc778ad2c521433edf7913bfb30.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek bebek alt giyim",Fiyat=80,ImageSource= new Uri("https://ktnimg.mncdn.com/mnresize/842/1105/product-images/9KMB48697ZK665/1500Wx1969H/9KMB48697ZK665_G01_zoom1_V03.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız bebek alt giyim",Fiyat=40,ImageSource=new Uri("https://n11scdn.akamaized.net/a1/500_750/giyim-ayakkabi/pijama-ve-gecelik/bgc-kids-renkli-desenli-1-4-yas-kiz-cocuk-polar-alt-giyim__1553857488785590.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek alt giyim	",Fiyat=50,ImageSource= new Uri("https://www.annesininherseyi.com/media/urun/350x500/2_salvar-modelli-popoda-goz-ifadeli-bebek-tek-alt-giyim-gri-resim-9802.jpg")}
            };

            Kategoribebekelbise = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kız çocuk pembe elbise",Fiyat=150,ImageSource=new Uri("https://www.mamaslina.com/Uploads/UrunResimleri/buyuk/kiz-bebek-cilekli-pembe-elbise-9527.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız bebek peri elbisesi",Fiyat=100,ImageSource= new Uri("https://dfcdn.defacto.com.tr/7/K8203A2_19SM_ER136_01_02.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek bebek takım elbise",Fiyat=120,ImageSource= new Uri("http://www.quzucukkids.com/Uploads/UrunResimleri/buyuk/erkek-bebek-takim-elbise-firsat-urunleri-a489.jpg")},
                new AnaSayfaRandomUrunler{Isim="bebek takım elbise",Fiyat=180,ImageSource= new Uri("https://www.civilim.com/productimages/315686/big/8681356832396frontcivil1200.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek bebek takım elbise oversize",Fiyat=80,ImageSource= new Uri("https://cdn.yeniakit.com.tr/images/album/bebekler-takim-elbise-giyerse-74cf65.jpg")}
            };

            Kategoribebekdısgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="mavi dış giyim",Fiyat=80,ImageSource=new Uri("https://img-lcwaikiki.mncdn.com/mnresize/600/-/pim/productimages/20202/4077675/l_20202-0w2240z1-hfh_a1.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek çocuk dış giyim",Fiyat=30,ImageSource= new Uri("https://image.dhgate.com/0x0s/f2-albu-g8-M00-44-15-rBVaVF3X7LuAK6urAASBINHNG84561.jpg/erkek-bebek-giyim-bebek-boys-kap-onlu-palto.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız çocuk dış giyim",Fiyat=50,ImageSource=new Uri("https://www.cartersoshkosh.com.tr/images/ST/C218558.BR.JPG")},
                new AnaSayfaRandomUrunler{Isim="kız çocuk dış giyim kırmızı model",Fiyat=100,ImageSource=new Uri("https://www.fiyatgrafik.com/foto-4/bebek-kiz-giyim-sevimli-bebek-kapsonlu-coat-elbise-bahar-sonbahar-yuruyor-bebek-bebek-dis-giyim-ceket-bebek-giysileri-ruzgarlik.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız çocuk pembe mont ",Fiyat=80,ImageSource=new Uri("https://para-nakliye.cam/pics/145511_1/Moda-%C3%A7ocuk-s%C4%B1cak-d%C4%B1%C5%9F-giyim-2019-k%C4%B1%C5%9F-bebek-k%C4%B1z.jpeg")}
            };


            Kategoribebekplajgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kız çocuk plaj giyim",Fiyat=60,ImageSource=new Uri("https://dnmk.co/2_storage/thumbs-Bebek-k%C4%B1z-mayo-%C3%87ocuk-Karikat%C3%BCr-Bikini-Tak%C4%B1m-Elbise-%C3%87ocuk-Plaj-Giyim-yaz-giysileri-2-8-T-K%C4%B1z-tek-par%C3%A7a-mayolar-ile-%C5%9Eapka_12717.jpeg")},
                new AnaSayfaRandomUrunler{Isim="erkek çocuk plaj müslin giyim ",Fiyat=40,ImageSource=new Uri("https://www.zelihabaysan.com/Uploads/UrunResimleri/thumb/cocuk-banyo-plaj-giysisi-mavi-7d8d.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek çocuk",Fiyat=30,ImageSource= new Uri("https://esrastyle.com/image/cache/wkseller//starinci/Uploads/UrunResimleri/erkek-cocuk-likra-mayoerkek-cocukarmeser-bf9e-248x350w.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız çocuk renkli giyim ",Fiyat=50,ImageSource=new Uri("https://cdn.perabulvari.com/peraimage/cdndata/3198/0/737.00.01.0907-1.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek plaj tam set giyim ",Fiyat=40,ImageSource=new Uri("https://www.dhresource.com/260x260/f2/albu/g6/M01/39/F1/rBVaSFpgPHOAfpTUAAFYaIawgLE642.jpg")}
            };

            Kategoribebekevgiyim = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="erkek ev pijama takımı", Fiyat=50,ImageSource=new Uri("https://www.blackspade.com.tr/erkek-cocuk-pijama-takimi-30409-gri-melanj-cocuk-ev-giyim-blackspade-30409-42069-12-O.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız ev pijama takımı",Fiyat=60,ImageSource=new Uri("https://www.kom.com.tr/media/catalog/product/cache/1/small_image/400x/040ec09b1e35df139433887a97daa66f/1/u/1u14ckpk201.001.c00184_1.jpg")},
                new AnaSayfaRandomUrunler{Isim="kız ev giyim ürünleri",Fiyat=40,ImageSource=new Uri("https://www.kompedan.com.tr/images/thumbs/0012007_ev-giyim_630.jpeg")},
                new AnaSayfaRandomUrunler{Isim="erkek ev bahçe giyim takımı",Fiyat=50,ImageSource=new Uri("https://sevimburada.com/erkek-cocuk-baskili-sort-takim-2863-yeni-sezon-svm-8195-7616-28-K.jpg")},
                new AnaSayfaRandomUrunler{Isim="unisex çocuk ev giyim takımı",Fiyat=60,ImageSource=new Uri("https://www.baykaronline.com/Uploads/UrunResimleri/thumb/baykar-erkek-cocuk-kaprili-pijama-taki-e-23e8.jpg")}
            };

            //ayakkabıkategoriler

            kategoriayakkabıspor = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="Gri kadın spor ayakkabı",Fiyat=120,ImageSource=new Uri("http://www.elleshoes.com/Uploads/UrunResimleri/buyuk/elodie-kadin-spor-ayakkabi-gri-kombin-9cba.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek spor ayakkabı ferrani",Fiyat=180,ImageSource=new Uri("https://cdn.dsmcdn.com/ty62/product/media/images/20210130/0/58520025/68040595/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="çocuk spor ayakkabı",Fiyat=150,ImageSource=new Uri("https://img-ayakkabidunyasi.mncdn.com/mnresize/400/400/Content/Images/Originals/0072062_0.jpeg")},
                new AnaSayfaRandomUrunler{Isim="kadın spor ayakkabı",Fiyat=200,ImageSource=new Uri("https://www.delisiyim.com/Uploads/UrunResimleri/thumb/orten-beyaz-tasli-lastikli-kadin-spor--f-f278.jpg	")},
                new AnaSayfaRandomUrunler{Isim="erkek spor ayakkabı adidas",Fiyat=250,ImageSource=new Uri("https://n11scdn.akamaized.net/a1/450/spor-outdoor/gunluk-spor-ayakkabi/adidas-energyfalcon-gri-erkek-kosu-ayakkabisi-ee9844__0633210956235763.jpg")}
            };

            Kategoribabet = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kadın siyah babet ayakkabı",Fiyat=120,ImageSource=new Uri("https://floimages.mncdn.com/media/catalog/product/20-11/11/new-project-2020-11-11t141707225.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadın deri babet ayakkabı",Fiyat=50,ImageSource=new Uri("https://cdn.pazarium.com.tr/100-deri-ortopedik-siyah-babet-ayakkabi-babet-ilker-ayakkabi-232319-40-B.jpg")},
                new AnaSayfaRandomUrunler{Isim="kahverengi deri babet kadın ayakakbı",Fiyat=140,ImageSource=new Uri("https://productimages.hepsiburada.net/s/58/600-800/11306178052146.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadın taşlı babet ayakkabı",Fiyat=150,ImageSource=new Uri("https://www.zindi.com.tr/Uploads/UrunResimleri/kadin-tasli-babet-ayakkabi-siyah-2b31.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadın babet sade siyah ayakkabı",Fiyat=80,ImageSource=new Uri("https://img.tozlu.com/Uploads/UrunResimleri/thumb/kadin-babet-ayakkabi-51f1e5.jpg")}
            };

            Kategoriince = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="Maytis siyah ince ayakkabı",Fiyat=140,ImageSource=new Uri("http://www.delisiyim.com/Uploads/UrunResimleri/buyuk/maytis-sderi-siyah--0aad.jpg")},
                new AnaSayfaRandomUrunler{Isim="Topuklu Kemal Tanca kırmızı",Fiyat=150,ImageSource=new Uri("https://tanca.akinoncdn.com/products/2020/04/17/67991/8352af58-50c9-463e-9495-352cf45d58fd_size780x780_cropCenter.jpg")},
                new AnaSayfaRandomUrunler{Isim="Nicole karamel ayakkabı",Fiyat=100,ImageSource=new Uri("https://www.yakisanial.com/public/uploads/all/t9AZxyaMvTgcpptFr9NDCEm92Z9uMo2dAS1sN8gd.jpg")},
                new AnaSayfaRandomUrunler{Isim="leopar desenli ayakkabı",Fiyat=130,ImageSource=new Uri("http://www.bayansepeti.com/Uploads/UrunResimleri/buyuk/leopar-desenli-ince-kemer-detayli-platfo-5e10.jpg")},
                new AnaSayfaRandomUrunler{Isim="siyah ince topluklu model kadın",Fiyat=100,ImageSource=new Uri("https://img2-hotic.mncdn.com/mnresize/595/595/Content/Images/Originals/3460783_0.jpeg")}

            };


            Kategoritopuklu = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="meri süet çapraz bant detaylı",Fiyat=120,ImageSource=new Uri("https://www.iloveshoes.com.tr/i/l/001/0014063_meri-suet-capraz-bant-detayli-yuksek-topuklu-ayakkabi-siyah.jpeg")},
                new AnaSayfaRandomUrunler{Isim="Raina siyah süet ayakkabı",Fiyat=70,ImageSource=new Uri("https://www.awonayakkabi.com/i/l/001/0010958_raina-siyah-suet-topuklu-ayakkabi.jpeg")},
                new AnaSayfaRandomUrunler{Isim="princess şeffaf gümüş kadın taşlı ayakkabı", Fiyat=100,ImageSource=new Uri("https://cdn03.ciceksepeti.com/cicek/kc2607858-1/L/princess-seffaf-gumus-kadin-topuklu-ayakkabi-kc2607858-1-bc94d423ec314c54a14a268868b5f1a4.jpg	")},
                new AnaSayfaRandomUrunler{Isim="gökçe kırmızı süet ayakkabı",Fiyat=120,ImageSource=new Uri("https://www.awonayakkabi.com/i/l/000/0006080_gokce-kirmizi-suet-topuklu-ayakkabi.jpeg")},
                new AnaSayfaRandomUrunler{Isim="İnga beyaz yüksek topuklu",Fiyat=150,ImageSource=new Uri("https://i.pinimg.com/originals/27/60/52/2760527e58376635bfc8909d53212ff2.jpg")}
            };

            Kategoribot = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="siyah rugan bot kadın",Fiyat=130,ImageSource=new Uri("https://fns.modanisa.com/r/pro2/2019/08/27/z-bot--siyah--ayakkabi-havuzu-1198854-1198854-1.jpg")},
                new AnaSayfaRandomUrunler{Isim="Crısso 523 Kauçuk bot ayakkabı erkek",Fiyat=120,ImageSource=new Uri("https://www.ayakkabicity.com/Uploads/UrunResimleri/buyuk/crisso-523-erkek-kaucuk-bot-8159.jpg")},
                new AnaSayfaRandomUrunler{Isim="Theg Bot ayakkabı",Fiyat=100,ImageSource=new Uri("https://gumrukdeposu.net/7415-thickbox_default/theg-bot-ayakkab-zt6101.jpg")},
                new AnaSayfaRandomUrunler{Isim="Scooter deri su geçirmez bot kadın",Fiyat=400,ImageSource=new Uri("https://cdn.dsmcdn.com/mnresize/415/622/ty16/product/media/images/20201008/23/14283785/91689900/0/0_org_zoom.jpg")},
                new AnaSayfaRandomUrunler{Isim="LumberJack erkek bot",Fiyat=200,ImageSource=new Uri("https://www.erdal.com.tr/lumberjack-erkek-bot-ayakkabi-100414812-20k-bot-lumberjack-15813-12-B.jpg")}

            };

            //kategori aksesuar

            Kategorigozluk = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="kadın gözlük",Fiyat=120,ImageSource=new Uri("https://www.chamakhbutik.com/Uploads/UrunResimleri/buyuk/Pilot-gozluk-5689.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kadın gözlğk Cat Eye",Fiyat=100,ImageSource=new Uri("https://productimages.hepsiburada.net/s/19/375/9846406316082.jpg")},
                new AnaSayfaRandomUrunler{Isim="en sevilen modeller erkek gözlük",Fiyat=150,ImageSource=new Uri("https://listelist.com/wp-content/uploads/2020/06/newhome-full-men_mobile_1280x.progressive.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek gözlük",Fiyat=160,ImageSource=new Uri("https://pbs.twimg.com/profile_images/646428656408109056/UIqCl3gV.jpg")},
                new AnaSayfaRandomUrunler{Isim="MEESHOW Gözlük çerçeve kadın",Fiyat=200,ImageSource=new Uri("https://personaldelivery.news/img/products/37754-meeshow-goezluek-cerceve-seffaf-erkek-kadn-goezluek-sk-recete-goezluek-goez-goezluek-vintage-goezluek-cerceve-chic-cerceve.jpg")}
            };


            Kategorisaat = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="Diesel erkek kol saati",Fiyat=250,ImageSource=new Uri("https://www.hizlisaat.com/diesel-dz4283-erkek-kol-saati-110828-82-O.jpg")},
                new AnaSayfaRandomUrunler{Isim="Toms Lacivert hasır çelik kordon",Fiyat=200,ImageSource=new Uri("https://www.saatinburada.com/Uploads/UrunResimleri/buyuk/toms-lacivert-hasir-celik-kordon-erkek-k-9b41.jpg")},
                new AnaSayfaRandomUrunler{Isim="Gümüş erkek saati",Fiyat=150,ImageSource=new Uri("https://www.hizlisaat.com/emporio-armani-ar11164-erkek-kol-saati-115630-83-K.jpg")},
                new AnaSayfaRandomUrunler{Isim="Minimal kare kadın saat",Fiyat=120,ImageSource=new Uri("https://cdn03.ciceksepeti.com/cicek/kc9675478-1/L/minimal-kare-kadin-saat-kc9675478-1-6ac1a3fe4a25465688d9c2cf18d30cd7.jpg")},
                new AnaSayfaRandomUrunler{Isim="büyük kadranlı kadın saati",Fiyat=140,ImageSource=new Uri("https://u.preparegood.news/img/products/34854-bueyuek-kadranl-saat-kadn-saatler-bayanlar-lueks-paslanmaz-celik-kuvars-bilek-saatleri-icin-kadn-saat-kadn-kol-saatleri-ile-tarih.jpg")}
            };

            Kategoritakı = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="inci kolye kadın takı",Fiyat=500,ImageSource=new Uri("https://tope.news/53430-1-large_default/Birden-%C3%A7ok-se%C3%A7im-inci-kolye-moda-G%C3%BCm%C3%BC%C5%9F-yaprak-%C4%B0mitasyon-%C4%B0nci-%C3%A7apraz-kolye-kad%C4%B1n-tak%C4%B1-hediye-parti-d%C3%BC%C5%9Fer.jpg")},
                new AnaSayfaRandomUrunler{Isim="Gümüş kolye seti Alibaba Tasarımcı",Fiyat=1000,ImageSource=new Uri("https://sc04.alicdn.com/kf/HTB1SYKeIVXXXXcTXFXXq6xXFXXX0.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kadın takı sade",Fiyat=1500,ImageSource=new Uri("https://www.takilingo.com/wp-content/uploads/2021/01/sonsuzluk-300x300.jpeg")},
                new AnaSayfaRandomUrunler{Isim="Erkek takı modeli zincir",Fiyat=200,ImageSource=new Uri("https://cdn.dsmcdn.com//ty67/product/media/images/20210325/11/75188234/65942855/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="erkek bileklik",Fiyat=300,ImageSource=new Uri("https://blog.newobsessions.com/wp-content/uploads/2019/12/erkek-bileklik-modelleri.jpg")}
            };

            Kategorikemer = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="Cool kadın kemer",Fiyat=50,ImageSource= new Uri("https://cdn.dsmcdn.com/ty93/product/media/images/20210404/11/f73be599/58020309/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="zincir detaylı kuşgözü kadın kemer",Fiyat=230,ImageSource=new Uri("https://www.ekatekstil.com/zincir-detayli-kusgozu-kemer-56145-13-K.jpg")},
                new AnaSayfaRandomUrunler{Isim="kadın deri kemer",Fiyat=180,ImageSource=new Uri("https://cdn-aing.akinon.net/products/2020/01/08/296645/67ce7fb2-75e1-447e-988f-f3fff165e238_size780x1020_cropCenter.jpg")},
                new AnaSayfaRandomUrunler{Isim="Taba erkek kemer",Fiyat=200,ImageSource=new Uri("https://img.tozlu.com/Uploads/UrunResimleri/buyuk/erkek-kemer-bc06.jpg")},
                new AnaSayfaRandomUrunler{Isim="kemer jack&jones ",Fiyat=350,ImageSource=new Uri("https://www.aksesuarix.com/UserFiles/Fotograflar/org/37142-jack-jones-jacharry-erkek-kemer-12120697sy-12120697-12120697-2476155-front-1.jpg")}
            };

            Kategorisapka = new ObservableCollection<AnaSayfaRandomUrunler>
            {
                new AnaSayfaRandomUrunler{Isim="Newyork NY erkek şapka",Fiyat=30,ImageSource=new Uri("http://www.mossta.com/Uploads/UrunResimleri/buyuk/new-york-ny-nakisli-erkek-sapka-7cb2.jpg")},
                new AnaSayfaRandomUrunler{Isim="DeepSea erkek geyik figürlü fileli şapka",Fiyat=50,ImageSource=new Uri("https://cdn03.ciceksepeti.com/cicek/kc3941661-1/XL/siyah-geyik-desen-fileli-erkek-sapka-2008883-kc3941661-1-ec52776087f642b5ad274e518066b429.jpg")},
                new AnaSayfaRandomUrunler{Isim="Yazılı baskılı şapka",Fiyat=70,ImageSource=new Uri("https://ktnimg.mncdn.com/mnresize/1500/1969/product-images/7YAM56013AA999/1500Wx1969H/7YAM56013AA999_G02_zoom2_V01.jpg")},
                new AnaSayfaRandomUrunler{Isim="Kadın şapka siyah baskısız",Fiyat=60,ImageSource=new Uri("https://cdn.dsmcdn.com//ty75/product/media/images/20210220/14/65421166/72267232/1/1_org.jpg")},
                new AnaSayfaRandomUrunler{Isim="Bucket şapka ponpon şapka kadın",Fiyat=80,ImageSource=new Uri("https://cdn.sorsware.com/oxxo/ContentImages/Product/21y/21YOX-NEWDERHAT/vegan-deri-bucket-sapka_black-siyah_1_detay.jpg")}
            };


        }

        public ObservableCollection<AnaSayfaRandomUrunler> AnaSayfaRandomUrunlers { get => anaSayfaRandomUrunlers; set => anaSayfaRandomUrunlers = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekust1 { get => Kategorierkekust; set => Kategorierkekust = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekalt { get => kategorierkekalt; set => kategorierkekalt = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekdışgiyim { get => kategorierkekdışgiyim; set => kategorierkekdışgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekplaj { get => kategorierkekplaj; set => kategorierkekplaj = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorierkekevgiyim { get => kategorierkekevgiyim; set => kategorierkekevgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadınustgiyim { get => kategorikadınustgiyim; set => kategorikadınustgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadınaltgiyim { get => kategorikadınaltgiyim; set => kategorikadınaltgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadınelbisegiyim { get => kategorikadınelbisegiyim; set => kategorikadınelbisegiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadındısgiyim { get => kategorikadındısgiyim; set => kategorikadındısgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadınplajgiyim { get => kategorikadınplajgiyim; set => kategorikadınplajgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikadınevgiyim { get => kategorikadınevgiyim; set => kategorikadınevgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekustgiyim { get => kategoribebekustgiyim; set => kategoribebekustgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekaltgiyim { get => kategoribebekaltgiyim; set => kategoribebekaltgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekelbise { get => kategoribebekelbise; set => kategoribebekelbise = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekdısgiyim { get => kategoribebekdısgiyim; set => kategoribebekdısgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekplajgiyim { get => kategoribebekplajgiyim; set => kategoribebekplajgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribebekevgiyim { get => kategoribebekevgiyim; set => kategoribebekevgiyim = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoriayakkabıspor { get => kategoriayakkabıspor; set => kategoriayakkabıspor = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribabet { get => kategoribabet; set => kategoribabet = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoriince { get => kategoriince; set => kategoriince = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoritopuklu { get => kategoritopuklu; set => kategoritopuklu = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoribot { get => kategoribot; set => kategoribot = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorigozluk { get => kategorigozluk; set => kategorigozluk = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorisaat { get => kategorisaat; set => kategorisaat = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategoritakı { get => kategoritakı; set => kategoritakı = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorikemer { get => kategorikemer; set => kategorikemer = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> Kategorisapka { get => kategorisapka; set => kategorisapka = value; }
    }
}
