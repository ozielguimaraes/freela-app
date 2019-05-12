using Prototipo.Services;
using Prototipo.Services.Mocks;
using Prototipo.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Empreendimento
{
    public class ListaEmpreendimentoPageModel : BasePageModel
    {
        public ICommand LoadItemsCommand { get; set; }
        public ICommand IrparaDetalhesCommand { get; set; }

        public ListaEmpreendimentoPageModel()
        {
            LoadItemsCommand = new Command(() => LoadItens());
            IrparaDetalhesCommand = new Command<Models.Empreendimento>(async (item) => await IrparaDetalhes(item));
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
            try
            {
                if (IsLoading) return;
                IsLoading = true;

                var mock = new EmpreendimentoMock();
                var itens = await mock.GetItemsAsync();
                Itens = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Id % 2 == 0).ToList());
                ItensEmPromocao = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Id % 2 != 0).ToList());
                ItensEmLancamento = new ObservableCollection<Models.Empreendimento>(itens.Where(w => w.Nome.StartsWith("A")).ToList());
            }
            catch (Exception ex)
            {
                IsLoading = false;
                await MessageService.ShowAsync(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async Task IrparaDetalhes(Models.Empreendimento item)
        {
            try
            {
                if (IsLoading) return;
                IsLoading = true;

                var service = new EmpreendimentoService();
                var itemFromServer = await service.ObterPorIdAsync(item.Id);
                if (itemFromServer == null)
                {
                    await MessageService.ShowAsync("Empreendimento não encontrado");
                    return;
                }

                await NavigationService.PushModalAsync(new NavigationPage(new DetalhesEmpreendimentoPage(itemFromServer)));
            }
            catch (Exception ex)
            {
                IsLoading = false;
                await MessageService.ShowAsync(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}