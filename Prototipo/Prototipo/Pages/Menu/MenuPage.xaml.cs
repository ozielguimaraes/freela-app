using Prototipo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo.Pages.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        private readonly MenuPageModel _pageModel;
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        public MenuPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _pageModel.LoadItemsCommand.Execute(null);
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //IsPresented = false;
            ((ListView)sender).SelectedItem = null;
            var item = (MenuItemVm)e.SelectedItem;
            if (item == null) return;

            var page = MenuHelper.GetPage(item);
            if (!string.IsNullOrWhiteSpace(page.Title)) Title = page.Title;
            //Detail = page;
        }
    }
}