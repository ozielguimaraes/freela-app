using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class NovaPropostaPage : TabbedPage
    {
        private readonly NovaPropostaPageModel _pageModel;

        public NovaPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new NovaPropostaPageModel();
        }
    }
}