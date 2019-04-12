using Prototipo.Attributes;
using Prototipo.Extensions;
using Prototipo.Models;
using Prototipo.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Proposta
{
    public class GravarCompradorPropostaPageModel : BasePageModel
    {
        public GravarCompradorPropostaPageModel()
        {
            Title = "Comprador";
            ListaEstadoCivil = EnumExtension.ConvertToList<EstadoCivil>();
            ListaTipoDocumento = EnumExtension.ConvertToList<TipoDocumento>();
            ListaEscolaridade = EnumExtension.ConvertToList<Escolaridade>();
            ListaGenero = EnumExtension.ConvertToList<Genero>();
        }

        private EnumValueDataAttribute _estadoCivil;
        public EnumValueDataAttribute EstadoCivil
        {
            get { return _estadoCivil; }
            set { SetProperty(ref _estadoCivil, value); }
        }

        private EnumValueDataAttribute _tipoDocumento;
        public EnumValueDataAttribute TipoDocumento
        {
            get { return _tipoDocumento; }
            set { SetProperty(ref _tipoDocumento, value); }
        }

        private EnumValueDataAttribute _escolaridade;
        public EnumValueDataAttribute Escolaridade
        {
            get { return _escolaridade; }
            set { SetProperty(ref _escolaridade, value); }
        }

        private EnumValueDataAttribute _genero;
        public EnumValueDataAttribute Genero
        {
            get { return _genero; }
            set { SetProperty(ref _genero, value); }
        }

        public List<EnumValueDataAttribute> ListaEstadoCivil { get; set; }
        public List<EnumValueDataAttribute> ListaTipoDocumento { get; set; }
        public List<EnumValueDataAttribute> ListaEscolaridade { get; set; }
        public List<EnumValueDataAttribute> ListaGenero{ get; set; }

        public CompradorVm Comprador { get; set; }
        public ObservableCollection<CompradorVm> Compradores { get; set; }
    }
}