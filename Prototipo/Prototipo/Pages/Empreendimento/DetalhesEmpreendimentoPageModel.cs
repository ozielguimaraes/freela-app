using Prototipo.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Prototipo.Pages.Empreendimento
{
    public class DetalhesEmpreendimentoPageModel : BasePageModel
    {
        public Models.Empreendimento Item { get; set; }

        private ObservableCollection<Models.Torre> torres;
        public ObservableCollection<Models.Torre> Torres
        {
            get { return torres; }
            set { SetProperty(ref torres, value); }
        }

        public DetalhesEmpreendimentoPageModel(Models.Empreendimento model)
        {
            Title = model.Nome;
            Item = model;
        }















































    }
}