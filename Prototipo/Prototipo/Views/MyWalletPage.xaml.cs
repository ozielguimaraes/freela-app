using Prototipo.Vms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyWalletPage : ContentPage
    {
        private readonly MyWalletVm _myWalletVm;

        public MyWalletPage()
        {
            InitializeComponent();

            BindingContext = _myWalletVm = _myWalletVm ?? new MyWalletVm();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _myWalletVm.LoadDetailsCommand.Execute(null);
        }
    }
}