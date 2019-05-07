using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class AbaPropostaPage : ContentPage
    {
        private readonly AbaPropostaPageModel _pageModel;

        public AbaPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new AbaPropostaPageModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_pageModel.PreChaves.Count == 0)
                _pageModel.LoadPreChavesCommand.Execute(null);
        }

        private async void AlterarEmpreendimento_Tapped(object sender, System.EventArgs e)
        {
            await _pageModel.MessageService.ShowAsync("clicou");
        }

        private async void IrParaDocumento_Tapped(object sender, System.EventArgs e)
        {
            //GravarPropostaPage.Nav = this;
        }
    }
}