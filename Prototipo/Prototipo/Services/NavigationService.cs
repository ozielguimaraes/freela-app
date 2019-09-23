using Prototipo.Pages;
using Prototipo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Prototipo.Services
{
    [Preserve(AllMembers = true)]
    public class NavigationService : INavigationService
    {
        private readonly ExceptionService ExceptionService;

        public NavigationService()
        {
            ExceptionService = new ExceptionService();
        }

        public void NavigateToUrl(string url)
        {
            Device.OpenUri(new Uri(url));
        }

        public void MakePhoneCall(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) return;

            NavigateToUrl($"tel:{number.Replace("(", "").Replace(")", "").Replace("-", "")}");
        }

        public void Navegar(Page page)
        {
            try
            {
                var main = Application.Current.MainPage as MainPage;
                //main.Detail = page;
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public async Task GoToAsync<T>(bool navigate) where T : class
        {
            var page = GetPage<T>();
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void GoToHome<T>() where T : class
        {
            var page = GetPage<T>();
            Application.Current.MainPage = page as Shell;
        }

        private Page GetPage<T>()
        {
            var pageModelType = typeof(T);
            var pageModelTypeName = pageModelType.Name;

            if (!pageModelType.FullName.Contains("Pages"))
                throw new Exception($"'{pageModelTypeName}' deve ficar dentro da pasta 'Pages'");

            if (!pageModelTypeName.EndsWith("PageModel"))
                throw new Exception($"'{pageModelTypeName}' terminar com 'PageModel'");

            var pageTypeName = pageModelType.FullName.Replace("PageModel", "Page");
            var pageType = Type.GetType(pageTypeName);
            if (pageType == null) throw new Exception($"Página '{pageType.Name}' não existe");

            if (!(Activator.CreateInstance(pageType) is Page page))
                throw new Exception($"Página '{pageTypeName}' não herda de 'Page'");

            if (page == null) throw new Exception($"Página '{pageType.Name}' não existe");

            if (!(Activator.CreateInstance(pageModelType) is T pageModel)) throw new Exception($"PageModel '{pageModelTypeName}' não existe");

            page.BindingContext = pageModel;

            return page;
        }

        public async Task PushAsync(Page page)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(page);
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public async Task PushModalAsync(Page page)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(page);
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public async Task PopAsync()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public async Task PopToRootAsync()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public async Task PopModalAsync()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public void RemovePage(Type type)
        {
            try
            {
                var page = (Page)Activator.CreateInstance(type);
                foreach (var item in GetNavigationStack())
                {
                    if (item == page) Application.Current.MainPage.Navigation.RemovePage(page);
                }
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public void RemovePage(Page page)
        {
            try
            {
                if (page == null) return;

                foreach (var item in GetNavigationStack())
                {
                    if (item == page) Application.Current.MainPage.Navigation.RemovePage(page);
                }
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }

        public IList<Page> GetNavigationStack()
        {
            try
            {
                return Application.Current.MainPage.Navigation.NavigationStack.ToList();
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
                throw;
            }
        }

        public Page GetCurrentPage()
        {
            try
            {
                var pages = GetNavigationStack();
                var page = pages.LastOrDefault();
                return page;
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
                throw;
            }
        }

        public void NavigateOut()
        {
            try
            {
                var account = DependencyService.Get<IAppManager>();
                account.Close();
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
            }
        }
    }
}