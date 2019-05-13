using Prototipo.Models;
using Prototipo.Pages.Proposta;
using Prototipo.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Empreendimento
{
    public class DetalhesEmpreendimentoPageModel : BasePageModel
    {
        public ICommand AdicionarPropostaCommand { get; set; }

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
            AdicionarPropostaCommand = new Command<Unidade>(AdicionarProposta);
        }

        private async void AdicionarProposta(Unidade unidade)
        {
            await NavigationService.PushModalAsync(new GravarPropostaPage(unidade));
        }
    }
}