using Prototipo.ViewModels;

namespace Prototipo.Pages.Proposta
{
    public class GravarPropostaPageModel : BasePageModel
    {
        private readonly PropostaVm propostaSelecionada;

        public GravarPropostaPageModel(PropostaVm proposta = null)
        {
            Title = proposta?.Numero > 0 ? "Editar Proposta" : "Nova Proposta";
            propostaSelecionada = proposta ?? new PropostaVm();
        }

        private AbaCompradorPropostaPageModel abaComprador;
        public AbaCompradorPropostaPageModel AbaComprador
        {
            get { return abaComprador; }
            set { SetProperty(ref abaComprador, value); }
        }

        private AbaDocumentoPropostaPageModel abaDocumento;
        public AbaDocumentoPropostaPageModel AbaDocumento
        {
            get { return abaDocumento; }
            set { SetProperty(ref abaDocumento, value); }
        }

        private AbaPropostaPageModel abaProposta;
        public AbaPropostaPageModel AbaProposta
        {
            get { return abaProposta; }
            set { SetProperty(ref abaProposta, value); }
        }
    }
}