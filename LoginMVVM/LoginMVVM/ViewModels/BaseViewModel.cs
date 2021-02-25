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
        public IAlertService AlertService { get; }
        public INavigationService NavigationService { get; }

        protected BaseViewModel(IAlertService alertService, INavigationService navigationService)
        {
            AlertService = alertService;
            NavigationService = navigationService;
        }

    }
}
