using Prototipo.ViewModels;
using Xamarin.Forms;

namespace Prototipo.Views
{
	public partial class CarteiraPage : ContentPage
    {
        private readonly CarteiraVm _vm;

        public CarteiraPage()
        {
            InitializeComponent();

            BindingContext = _vm = _vm ?? new CarteiraVm();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _vm.LoadDetailsCommand.Execute(null);
        }
    }
}