using Prototipo.Attributes;
using Prototipo.Extensions;
using Prototipo.Models;
using Prototipo.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class AbaCompradorPropostaPageModel : BasePageModel
    {
        public AbaCompradorPropostaPageModel()
        {
            Title = "Comprador";
            ListaEstadoCivil = EnumExtension.ConvertToList<EstadoCivil>();
            ListaTipoDocumento = EnumExtension.ConvertToList<TipoDocumento>();
            ListaEscolaridade = EnumExtension.ConvertToList<Escolaridade>();
            ListaGenero = EnumExtension.ConvertToList<Genero>();
        }

        public List<EnumValueDataAttribute> ListaEstadoCivil { get; set; }
        public List<EnumValueDataAttribute> ListaTipoDocumento { get; set; }
        public List<EnumValueDataAttribute> ListaEscolaridade { get; set; }
        public List<EnumValueDataAttribute> ListaGenero{ get; set; }

        public CompradorVm Comprador { get; set; }
        public ObservableCollection<CompradorVm> Compradores { get; set; }
    }
}