using Prototipo.ViewModels;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class ListaPropostaPage : ContentPage
    {
        private readonly ListaPropostaPageModel _pageModel;

        public ListaPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new ListaPropostaPageModel();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Models.Proposta;
            if (item == null) return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailVm(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_pageModel.Items.Count == 0)
                _pageModel.LoadItemsCommand.Execute(null);
        }
    }
}