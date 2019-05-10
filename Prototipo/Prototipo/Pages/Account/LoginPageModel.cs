using Prototipo.Services;
using Prototipo.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Account
{
    public class LoginPageModel : BasePageModel
    {
        public ICommand EfetuarLoginCommand { get; set; }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { SetProperty(ref senha, value); }
        }

        private string login;
        public string Login
        {
            get { return login; }
            set { SetProperty(ref login, value); }
        }

        public LoginPageModel()
        {
            IsLoading = false;
            EfetuarLoginCommand = new Command(async () => await EfetuarLogin());
        }

        private async Task EfetuarLogin()
        {
            try
            {
                if (IsLoading) return;
                IsLoading = true;

                var service = new AccountService();
                var autenticado = await service.AutenticarAsync(Login, Senha);

                if (autenticado)
                {
                    await NavigationService.PushModalAsync(new MainPage());
                    NavigationService.RemovePage(NavigationService.GetCurrentPage());
                    return;
                }

                await MessageService.ShowAsync("Não foi possível autenticar");
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
                IsLoading = false;
                await MessageService.ShowAsync("Não foi possível completar o seu login");
            }
            finally { IsLoading = false; }
        }
    }
}