using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Infrastructure
{
    using ViewModel;
    public class InstanceLocator
    {
        #region Properies
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion


    }
}
