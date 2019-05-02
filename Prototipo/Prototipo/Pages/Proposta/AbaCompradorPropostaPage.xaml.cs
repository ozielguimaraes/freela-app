using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class AbaCompradorPropostaPage : ContentPage
    {
        private readonly AbaCompradorPropostaPageModel _pageModel;

        public AbaCompradorPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new AbaCompradorPropostaPageModel();
        }
    }
}