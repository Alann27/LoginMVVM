using Acr.UserDialogs;
using LoginMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace LoginMVVM.Services
{
    public class LoginAppServices
    {

        public Task AlertAsync(string title, string description)
        {
            return UserDialogs.Instance.AlertAsync(description, title);
        }

        public Task GoToSignUpPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new SignUpPage());

            return Task.CompletedTask;
        }

        public Task GoToHomePage()
        {
            App.Current.MainPage.Navigation.PushModalAsync(new HomePage());

            return Task.CompletedTask;
        }


    }
}
