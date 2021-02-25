using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginMVVM.Services
{
    public interface IAlertService
    {
        public Task AlertAsync(string title, string description);

    }
}
