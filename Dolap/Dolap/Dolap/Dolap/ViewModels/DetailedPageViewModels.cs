using Dolap.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dolap.ViewModels
{
   public class DetailedPageViewModels
    {
        private AnaSayfaRandomUrunler AnaSayfaRandomUrunler;

        public DetailedPageViewModels(AnaSayfaRandomUrunler anaSayfaRandomUrunler)
        {
            this.AnaSayfaRandomUrunler1 = anaSayfaRandomUrunler;
        }

        public AnaSayfaRandomUrunler AnaSayfaRandomUrunler1 { get => AnaSayfaRandomUrunler; set => AnaSayfaRandomUrunler = value; }
    }
}
