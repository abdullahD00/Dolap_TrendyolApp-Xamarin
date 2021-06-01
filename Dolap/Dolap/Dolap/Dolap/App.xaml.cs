using Dolap.ÖdemeEkranıStuff;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dolap.Services;
using System.IO;

namespace Dolap
{
    public partial class App : Application
    {
        private static DBService dBService;

        public static DBService DBService { get => dBService; set => dBService = value; }

        public App()
        {
            InitializeComponent();
            DBService = new DBService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "xamarinDB.db3"));

            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
