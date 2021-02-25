using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginMVVM.Services
{
    public class NavigationService : INavigationService
    {
        public Task ModalPushNavigationAsync(Page page)
        {
            return App.Current.MainPage.Navigation.PushAsync(page);
        }

        public Task NonModalPushNavigationAsync(Page page)
        {
            return App.Current.MainPage.Navigation.PushModalAsync(page);
        }
    }
}
