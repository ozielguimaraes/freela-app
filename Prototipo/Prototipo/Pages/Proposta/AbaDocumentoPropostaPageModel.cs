using Prototipo.ViewModels;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class AbaDocumentoPropostaPageModel : BasePageModel
    {
        public ObservableCollection<Models.Documento> Items { get; set; }

        public AbaDocumentoPropostaPageModel()
        {
            Items = new ObservableCollection<Models.Documento>();
        }
    }
}