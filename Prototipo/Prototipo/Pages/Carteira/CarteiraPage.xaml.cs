using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Prototipo.Pages.Carteira
{
    public partial class CarteiraPage : ContentPage
    {
        private readonly CarteiraPageModel _pageModel;

        public CarteiraPage()
        {
            InitializeComponent();

            BindingContext = _pageModel = _pageModel ?? new CarteiraPageModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                _pageModel.LoadDetailsCommand.Execute(null);
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