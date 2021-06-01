using Dolap.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dolap.ViewModels
{
   public class SignUpViewModels : BaseViewModel
    {
        
        string password;
        string name;
       
        
       
        ICommand singUpCommand;
       

        public SignUpViewModels()
        {
             singUpCommand = new Command(singUpFunction);
        }
        public string UserName
        {
            get => UserName; set
            {
                if (UserName != value)
                    UserName = value;

            }
        }


        public async void singUpFunction()
        {
            USER u = new USER();
            u.PASSWORD = Password;
            
            u.NAME = Name;

            string status = (await App.DBService.addUser(u)).ToString();
            //  string status = await App.UserService.addUser(u);
            if (status != "0")
            {

                await App.Current.MainPage.DisplayAlert("Message", "Kayıt Başarılı.", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();
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
        public string Name
        {
            get => name; set
            {
                if (name != value)
                    name = value;
            }
        }
       
       

        
        public ICommand SingUpCommand { get => singUpCommand; set => singUpCommand = value; }
      



    }
}
