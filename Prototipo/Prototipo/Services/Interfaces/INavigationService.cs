using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Services.Interfaces
{
    public interface INavigationService
    {
        void GoToHome<T>() where T : class;
        void NavigateToUrl(string url);
        void MakePhoneCall(string number);
        Task PushModalAsync(Page page);
        void Navegar(Page page);
        Task GoToAsync<T>(bool navigate = false) where T : class;
        Task PushAsync(Page page);
        Task PopAsync();
        Task PopToRootAsync();
        Task PopModalAsync();
        void RemovePage(Type type);
        void RemovePage(Page page);
        IList<Page> GetNavigationStack();
        Page GetCurrentPage();
        void NavigateOut();
    }
}