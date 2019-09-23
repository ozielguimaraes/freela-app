using Prototipo.Helpers;
using Prototipo.Pages.Menu;
using Prototipo.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Pages
{
    public partial class MainPage : Shell
    {
        private readonly MenuPageModel _pageModel;

        public MainPage()
        {
            InitializeComponent();
            RegisterRoutes();
            Title = Constants.AppName;
            BindingContext = _pageModel = new MenuPageModel();
            //Detail = new NavigationPage(new Carteira.CarteiraPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _pageModel.LoadItemsCommand.Execute(null);
        }

        private void RegisterRoutes()
        {
            PageHelper.RegisterRoutes();
        }

        //private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    IsPresented = false;
        //    ((ListView)sender).SelectedItem = null;
        //    var item = (MenuItemVm)e.SelectedItem;
        //    if (item == null) return;

        //    var page = MenuHelper.GetPage(item);
        //    if (page != null && Detail != page)
        //    {
        //        if (!string.IsNullOrWhiteSpace(page.Title)) Title = page.Title;

        //        IsPresented = false;

        //        await Detail.Navigation.PushAsync(page);
        //        //if (Device.RuntimePlatform == Device.Android)
        //        //    await Task.Delay(100);
        //    }
        //}
    }
}