using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginMVVM.Services
{
    public interface INavigationService
    {
        public Task NonModalPushNavigationAsync(Page page);
        public Task ModalPushNavigationAsync(Page page);
    }
}
