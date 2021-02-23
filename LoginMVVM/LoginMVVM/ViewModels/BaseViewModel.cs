using LoginMVVM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoginMVVM.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public LoginAppServices LoginAppServices { get; set; }

        protected BaseViewModel(LoginAppServices loginAppServices)
        {
            LoginAppServices = loginAppServices;
        }
    }
}
