using LoginMVVM.Models;
using LoginMVVM.Services;
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
        public SignUpViewModel(LoginAppServices loginAppServices) : base(loginAppServices)
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
                    await LoginAppServices.AlertAsync("INTEC App", $"Bienvenido, {User.Name}!");

                    await LoginAppServices.GoToHomePage();
                }
                else
                {
                    await LoginAppServices.AlertAsync("Error", "Las contraseñas no coinciden, favor introducirlas nuevamente");
                }
            }
            else
            {
                await LoginAppServices.AlertAsync("Error", "Faltan campos por llenar, favor verifique e intente de nuevo");
            }
        }
    }
}
