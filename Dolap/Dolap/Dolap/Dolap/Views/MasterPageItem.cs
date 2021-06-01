using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dolap.Views
{
   public class MasterPageItem
    {
        public string title;
        public Type targetType;
        private string detail;
        private ImageSource ıcon;

        public Type TargetType { get => targetType; set => targetType = value; }
        public string Title { get => title; set => title = value; }
        public string Detail { get => detail; set => detail = value; }
        public ImageSource Icon { get => ıcon; set => ıcon = value; }
    }
}
