using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo.Pages.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly LoginPageModel _pageModel;

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new LoginPageModel();
        }
    }
}