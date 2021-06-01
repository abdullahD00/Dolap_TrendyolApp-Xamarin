using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Dolap.Models;
using Xamarin.Forms;

namespace Dolap.ViewModels
{


    public class SepeteEkleViewModel
    {
        public float fiyat;
        public string ısim;
        public ImageSource ımageSource;
        private int toplamtutar;
        ICommand sptekle;
        ObservableCollection<AnaSayfaRandomUrunler> anaSayfaRandomUrunlersepet;

       
        public int Toplamtutar { get => toplamtutar; set {
                if (toplamtutar!=value)
                {
                    toplamtutar = value;
                }
            } }
        public ICommand Sptekle { get => sptekle; set => sptekle = value; }
        public ObservableCollection<AnaSayfaRandomUrunler> AnaSayfaRandomUrunlersepet { get => anaSayfaRandomUrunlersepet; set => anaSayfaRandomUrunlersepet = value; }
        public float Fiyat { get => fiyat; set {
                if (fiyat!=value)
                {
                    fiyat = value;
                }
            } }
        public string Isim { get => ısim; set {
                if (ısim!=value)
                {
                    ısim = value;
                }
            } }
        public ImageSource ImageSource { get => ımageSource; set {
                if (ımageSource!=value)
                {
                    ımageSource = value;
                }
            } }

        public SepeteEkleViewModel()
        {
            Sptekle = new Command(sepeteekle);

          


        }

        public  void sepeteekle()
        {
            AnaSayfaRandomUrunler urun = new AnaSayfaRandomUrunler();

            urun.Isim = this.ısim;
            urun.Fiyat = this.fiyat;
            urun.ImageSource = this.ımageSource;

            //anaSayfaRandomUrunlersepet.Add(urun);



        }

        
        
    }
}
