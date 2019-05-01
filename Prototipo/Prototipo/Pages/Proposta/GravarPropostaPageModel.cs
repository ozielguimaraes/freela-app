using Prototipo.ViewModels;

namespace Prototipo.Pages.Proposta
{
    public class GravarPropostaPageModel : BasePageModel
    {
        public GravarPropostaPageModel(PropostaVm proposta = null)
        {
            Inicializar(proposta);
        }

        private PropostaVm _proposta;
        public PropostaVm Proposta
        {
            get { return _proposta; }
            set { SetProperty(ref _proposta, value); }
        }

        private void Inicializar(PropostaVm proposta)
        {
            Title = proposta == null ? "Nova Proposta" : "Editar Proposta";
            Proposta = proposta ?? new PropostaVm();
        }
    }
}