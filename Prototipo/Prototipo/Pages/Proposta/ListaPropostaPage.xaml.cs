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

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is PropostaVm item)) return;
            // Manually deselect item.
            ItemsListView.SelectedItem = null;

            await _pageModel.NavigationService.PushModalAsync(new NavigationPage(new GravarPropostaPage(item)));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_pageModel.Items.Count == 0)
                _pageModel.LoadItemsCommand.Execute(null);
        }
    }
}