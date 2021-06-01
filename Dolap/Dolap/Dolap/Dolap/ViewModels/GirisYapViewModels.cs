using Dolap.NavigationPageFolders;
using Dolap.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dolap.ViewModels
{
    class GirisYapViewModels : BaseViewModel
    {

        string username;
        string password;
        string loginStatus;
        ICommand loginCommand;
        ICommand signUpCommand;
        public GirisYapViewModels()
        {
           
            LoginCommand = new Command(loginFunction);
            
        }

        public async void loginFunction()
        {
            USER u = await App.DBService.LoginFunction(Username, Password);
            if (u == null)
            {


                LoginStatus = "Oturum Açma Başarısız";


            }
            else
            {

                LoginStatus = "Oturum Açma Başarılı";
               
            }
        }

        

        public string Username
        {
            get => username; set
            {
                if (username != value)
                    username = value;
            }
        }
        public string Password
        {
            get => password; set
            {
                if (password != value)
                    password = value;
            }
        }
       
        public string LoginStatus
        {
            get => loginStatus; set
            {
                if (loginStatus != value)
                {
                    loginStatus = value;
                    OnPropertyChanged("LoginStatus");
                }
            }
        }

        public ICommand LoginCommand { get => loginCommand; set => loginCommand = value; }
        public ICommand SignUpCommand { get => signUpCommand; set => signUpCommand = value; }


    }
}
