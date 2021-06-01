using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Dolap.Models;


namespace Dolap.Services
{
   public class AnasayfakaydirmalifotoCreator
    {

        private ObservableCollection<Anasayfakaydirmalifoto> foto;

        public AnasayfakaydirmalifotoCreator()
        {
            Foto = new ObservableCollection<Anasayfakaydirmalifoto>
            { 
                new Anasayfakaydirmalifoto{ImageSource="kaydir1.jpeg"},
                new Anasayfakaydirmalifoto{ImageSource="kaydir2.jpeg" },
                new Anasayfakaydirmalifoto{ImageSource="kaydir3.jpeg"}
            };
        }

        public ObservableCollection<Anasayfakaydirmalifoto> Foto { get => foto; set => foto = value; }
    }
}
