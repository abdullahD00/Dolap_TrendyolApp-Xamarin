using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Dolap.Models;
namespace Dolap.ViewModels
{
   public class AnasayfakaydirmalifotoViewsModels
    {
        ObservableCollection<Anasayfakaydirmalifoto> anasayfakaydirmalifotos;

        public AnasayfakaydirmalifotoViewsModels()
        {
            Anasayfakaydirmalifotos = new ObservableCollection<Anasayfakaydirmalifoto>
            {
                new Anasayfakaydirmalifoto{ImageSource="kaydir1.jpeg"},
                new Anasayfakaydirmalifoto{ImageSource="kaydir2.jpeg"},
                new Anasayfakaydirmalifoto{ImageSource="kaydir3.jpeg"}
            };
        }


        public ObservableCollection<Anasayfakaydirmalifoto> Anasayfakaydirmalifotos { get => anasayfakaydirmalifotos; set => anasayfakaydirmalifotos = value; }
    }
}
