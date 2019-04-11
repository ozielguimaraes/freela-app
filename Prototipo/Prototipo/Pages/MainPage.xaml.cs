using Prototipo.Pages.Menu;
using Prototipo.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Pages
{
    public partial class MainPage : MasterDetailPage
    {
        private readonly MenuPageModel _pageModel;

        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;

            BindingContext = _pageModel = new MenuPageModel();
        }

        public MainPage(Page detail)
        {
            InitializeComponent();
            BindingContext = _pageModel = new MenuPageModel();
            Detail = detail;
            IsPresented = false;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _pageModel.LoadItemsCommand.Execute(null);
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            IsPresented = false;
            ((ListView)sender).SelectedItem = null;
            var item = (MenuItemVm)e.SelectedItem;
            if (item == null) return;

            var page = MenuHelper.GetPage(item);
            if (page != null && Detail != page)
            {
                if (!string.IsNullOrWhiteSpace(page.Title)) Title = page.Title;

                Detail = item.Type == MenuType.Carteira ? page : new NavigationPage(page);
                //if (Device.RuntimePlatform == Device.Android)
                //    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}