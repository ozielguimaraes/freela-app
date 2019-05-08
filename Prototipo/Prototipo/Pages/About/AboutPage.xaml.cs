using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo.Pages.About
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutPageModel();
        }
    }
}