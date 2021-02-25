using LoginMVVM.Models;
using LoginMVVM.Services;
using LoginMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    class SignUpViewModel : BaseViewModel
    {
        public User User { get; set; } = new User();
        public string ConfirmPassword { get; set; }
        public ICommand SignUpCommand { get; }
        public SignUpViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            SignUpCommand = new Command(OnSignUp);
        }

        private async void OnSignUp()
        {
            if (!string.IsNullOrEmpty(User.Name) && !string.IsNullOrEmpty(User.Email)
                 && !string.IsNullOrEmpty(User.Password) && !string.IsNullOrEmpty(ConfirmPassword))
            {

                if (User.Password== ConfirmPassword)
                {
                    await AlertService.AlertAsync("INTEC App", $"Bienvenido, {User.Name}!");

                    await NavigationService.ModalPushNavigationAsync(new HomePage());
                }
                else
                {
                    await AlertService.AlertAsync("Error", "Las contraseñas no coinciden, favor introducirlas nuevamente");
                }
            }
            else
            {
                await AlertService.AlertAsync("Error", "Faltan campos por llenar, favor verifique e intente de nuevo");
            }
        }
    }
}
