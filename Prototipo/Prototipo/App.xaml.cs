using DLToolkit.Forms.Controls;
using Prototipo.Pages;
using Prototipo.Pages.Account;
using Prototipo.Services;
using Prototipo.Services.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            InicializarPlugins();
#if DEBUG
            HotReloader.Current.Start(this);
#endif
            MainPage = new NavigationPage(new LoginPage());
        }

        private void InicializarPlugins()
        {
            FlowListView.Init();
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
