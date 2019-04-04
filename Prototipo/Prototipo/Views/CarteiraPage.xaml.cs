using Prototipo.Services;
using Prototipo.ViewModels;
using System;
using System.Diagnostics;
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

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                var mock = new CarteiraMock();
                var item = await mock.GetItemAsync(string.Empty);
                _vm.LoadDetailsCommand.Execute(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}