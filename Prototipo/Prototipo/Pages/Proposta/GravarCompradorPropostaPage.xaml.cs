using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class GravarCompradorPropostaPage : ContentPage
    {
        private readonly GravarCompradorPropostaPageModel _pageModel;

        public GravarCompradorPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new GravarCompradorPropostaPageModel();
        }
    }
}