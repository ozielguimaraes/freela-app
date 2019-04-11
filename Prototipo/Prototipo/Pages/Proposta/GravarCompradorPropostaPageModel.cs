using Prototipo.Models;
using Prototipo.ViewModels;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class GravarCompradorPropostaPageModel : BasePageModel
    {
        public GravarCompradorPropostaPageModel()
        {
            Title = "Comprador";
        }

        public CompradorVm Comprador { get; set; }
        public ObservableCollection<CompradorVm> Compradores { get; set; }
    }
}