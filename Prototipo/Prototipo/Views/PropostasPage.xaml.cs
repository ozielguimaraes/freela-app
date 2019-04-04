using Prototipo.Models;
using Prototipo.ViewModels;
using Xamarin.Forms;

namespace Prototipo.Views
{
    public partial class PropostasPage : ContentPage
    {
        private readonly PropostasVm _vm;

        public PropostasPage()
        {
            InitializeComponent();
            BindingContext = _vm = _vm ?? new PropostasVm();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Proposta;
            if (item == null) return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailVm(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_vm.Items.Count == 0)
                _vm.LoadItemsCommand.Execute(null);
        }
    }
}