using LoginMVVM.Models;
using LoginMVVM.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public LoginViewModel(LoginAppServices loginAppServices) : base(loginAppServices)
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnLogin()
        {
            if (!string.IsNullOrEmpty(User.Email) && !string.IsNullOrEmpty(User.Password))
            {
                await LoginAppServices.AlertAsync("INTEC App", $"Bienvenido, {User.Email}!");

                await LoginAppServices.GoToHomePage();
            }
            else
            {
                await LoginAppServices.AlertAsync("INTEC App", "Campo Email y/o contraseña no puede estar vacío");
            }
        }

        private async void OnRegister()
        {
            await LoginAppServices.GoToSignUpPage();
        }
    }
}
