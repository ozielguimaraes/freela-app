using Prototipo.ViewModels;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class GravarPropostaPage : TabbedPage
    {
        private readonly GravarPropostaPageModel _pageModel;

        public GravarPropostaPage(PropostaVm proposta = null)
        {
            Inicializar();
            BindingContext = _pageModel = _pageModel ?? new GravarPropostaPageModel(proposta);
        }

        private void Inicializar()
        {
            InitializeComponent();
        }
    }
}