using Prototipo.Models;
using Prototipo.ViewModels;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class GravarPropostaPage : TabbedPage
    {
        private readonly GravarPropostaPageModel _pageModel;
        public AbaCompradorPropostaPage Comprador { get; set; }

        public GravarPropostaPage(PropostaVm proposta = null)
        {
            Inicializar();
            BindingContext = _pageModel = _pageModel ?? new GravarPropostaPageModel(proposta);

            Comprador = Comprador ?? new AbaCompradorPropostaPage();
            //Comprador.AdicionarDocumentos_Clicked += AdicionarDocumentos;
            Children.Add(Comprador);

            Children.Add(new AbaDocumentoPropostaPage());
            Children.Add(new AbaPropostaPage());
        }

        public GravarPropostaPage(Unidade unidade)
        {
            //todo usar unidade selecionada
            Inicializar();
            BindingContext = _pageModel = _pageModel ?? new GravarPropostaPageModel();

            Comprador = Comprador ?? new AbaCompradorPropostaPage();
            //Comprador.AdicionarDocumentos_Clicked += AdicionarDocumentos;
            Children.Add(Comprador);

            Children.Add(new AbaDocumentoPropostaPage());
            Children.Add(new AbaPropostaPage());
        }

        private void Inicializar()
        {
            InitializeComponent();
        }

        private void AdicionarDocumentos(object sender, System.EventArgs e)
        {
            TabIndex = 1;
        }
    }
}