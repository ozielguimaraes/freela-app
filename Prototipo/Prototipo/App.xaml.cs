using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prototipo.Services.Interfaces;
using Prototipo.Services;
using Prototipo.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prototipo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<IExceptionService, ExceptionService>();
            DependencyService.Register<INavigationService, NavigationService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
