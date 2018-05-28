using System;
using System.Collections.Generic;
using System.Text;

namespace App7.ViewModel
{
   public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public PartidosViewModel Partidos
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton

        #endregion
    }
}
