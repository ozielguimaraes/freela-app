using DLToolkit.Forms.Controls;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
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
            MainPage = new LoginPage();
        }

        private void InicializarPlugins()
        {
            FlowListView.Init();
        }

        protected override void OnStart()
        {
            base.OnStart();
            AppCenter.Start($"android={Constants.AppCenter.Android};ios={Constants.AppCenter.iOS}", typeof(Analytics), typeof(Crashes));
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