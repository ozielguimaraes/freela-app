using Prototipo.ViewModels;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class GravarDocumentoPropostaPageModel : BasePageModel
    {
        public ObservableCollection<Models.Documento> Items { get; set; }

        public GravarDocumentoPropostaPageModel()
        {
            Items = new ObservableCollection<Models.Documento>();
        }
    }
}