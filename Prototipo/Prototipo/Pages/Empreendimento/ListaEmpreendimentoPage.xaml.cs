using Xamarin.Forms;

namespace Prototipo.Pages.Empreendimento
{
    public partial class ListaEmpreendimentoPage : ContentPage
    {
        private readonly ListaEmpreendimentoPageModel _pageModel;

        public ListaEmpreendimentoPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new ListaEmpreendimentoPageModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _pageModel.LoadItemsCommand.Execute(null);
        }
    }
}