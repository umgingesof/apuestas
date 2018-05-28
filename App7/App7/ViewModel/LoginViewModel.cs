using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;
using App7.Views;


namespace App7.ViewModel
{
    public class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get;
            set;
        }
 
        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            //this.IsRunning = true;
        }
        #endregion

        #region Command
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
         }
        private async void Login()
        {
           // if(this.Email == "")
           if (string.IsNullOrEmpty(this.Email))
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
                    "MsgError...", 
                    "Debe ingresar correo", 
                    "Ok");
                return;
            }

           
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new PartidosPage());
        }
        #endregion

    }
}
