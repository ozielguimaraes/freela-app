using Prototipo.Services.Mocks;
using Prototipo.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Empreendimento
{
    public class ListaEmpreendimentoPageModel : BasePageModel
    {
        public ICommand LoadItemsCommand { get; set; }

        public ListaEmpreendimentoPageModel()
        {
            LoadItemsCommand = new Command(() => LoadItens());
            //Itens = new ObservableCollection<Models.Empreendimento>();
            //ItensEmPromocao = new ObservableCollection<Models.Empreendimento>();
            //ItensEmLancamento = new ObservableCollection<Models.Empreendimento>();
        }

        private ObservableCollection<Models.Empreendimento> itens;
        public ObservableCollection<Models.Empreendimento> Itens
        {
            get { return itens; }
            set { SetProperty(ref itens, value); }
        }


        private ObservableCollection<Models.Empreendimento> itensEmPromocao;
        public ObservableCollection<Models.Empreendimento> ItensEmPromocao
        {
            get { return itensEmPromocao; }
            set { SetProperty(ref itensEmPromocao, value); }
        }

        private ObservableCollection<Models.Empreendimento> itensEmLancamento;
        public ObservableCollection<Models.Empreendimento> ItensEmLancamento
        {
            get { return itensEmLancamento; }
            set { SetProperty(ref itensEmLancamento, value); }
        }

        private async void LoadItens()
        {
            var mock = new EmpreendimentoMock();
            var itens = await mock.GetItemsAsync();
            Itens = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Id % 2 == 0).ToList());
            ItensEmPromocao = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Id % 2 != 0).ToList());
            ItensEmLancamento = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Nome.StartsWith("A")).ToList());
        }
    }
}