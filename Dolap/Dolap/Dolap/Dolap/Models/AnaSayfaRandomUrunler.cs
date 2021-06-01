using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dolap.Models
{
  public  class AnaSayfaRandomUrunler
    {
        public float fiyat;
        public string ısim;
        public ImageSource ımageSource;

        public float Fiyat { get => fiyat; set => fiyat = value; }
        public string Isim { get => ısim; set => ısim = value; }
        public ImageSource ImageSource { get => ımageSource; set => ımageSource = value; }
    }
}
