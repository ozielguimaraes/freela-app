using Prototipo.Helpers;
using Prototipo.Services.Interfaces;
using Prototipo.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Menu
{
    public class MenuPageModel : BasePageModel
    {
        private ObservableRangeCollection<MenuItemVm> _items;
        public ObservableRangeCollection<MenuItemVm> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public string AppVersion { get; set; }

        public ICommand LoadItemsCommand { get; set; }
        public ICommand VersionCommand { get; set; }

        public MenuPageModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadItems());
            VersionCommand = new Command(async () => await ExecuteVersion());
            AppVersion = $"Versão {DependencyService.Get<IAppVersion>().GetVersion()}";
        }

        private async Task ExecuteLoadItems()
        {
            try
            {
                if (IsLoading) return;
                IsLoading = true;

                var items = await MenuHelper.Build();

                Items = new ObservableRangeCollection<MenuItemVm>(items);
            }
            catch (Exception ex)
            {
                ExceptionService.TrackError(ex);
                await MessageService.ShowAsync(ex);
            }
            finally
            {
                IsLoading = false;
                IsPresented = false;
            }
        }

        private async Task ExecuteVersion()
        {
            var wannaToContactDeveloper = await MessageService.ShowConfirmationAsync($"O aplicativo {Constants.AppName}, foi desenvolvido por Guimarães Tecnologies.\nDeseja entrar em contato com o desenvolvedor?", "Sim", "Agora não");
            if (wannaToContactDeveloper) NavigationService.NavigateToUrl(Constants.DeveloperUrl);
        }
    }
}