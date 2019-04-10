using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class GravarPropostaPage : TabbedPage
    {
        private readonly GravarPropostaPageModel _pageModel;

        public GravarPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new GravarPropostaPageModel();
        }
    }
}