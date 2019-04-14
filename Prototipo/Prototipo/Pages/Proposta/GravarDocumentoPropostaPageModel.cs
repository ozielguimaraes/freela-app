using Prototipo.ViewModels;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class GravarDocumentoPropostaPageModel : BasePageModel
    {
        public ObservableCollection<Models.Proposta> Items { get; set; }

        public GravarDocumentoPropostaPageModel()
        {
            Items = new ObservableCollection<Models.Proposta>
            {
                new Models.Proposta{ }
            };
        }
    }
}