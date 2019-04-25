using Prototipo.Services.Mocks;
using Prototipo.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public class ListaPropostaPageModel : BasePageModel
    {
        public ObservableCollection<Models.Proposta> Items { get; set; }
        public ICommand LoadItemsCommand => new Command(async () => await LoadItems());
        public ICommand ItemSelectedCommand => new Command<int>(async (id) => await ItemSelecionado(id));

        public ListaPropostaPageModel()
        {
            Title = "Minhas Propostas";
            Items = new ObservableCollection<Models.Proposta>();
        }

        private async Task LoadItems()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var mock = new PropostaMock();
                var items = await mock.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task ItemSelecionado(int id)
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var mock = new PropostaMock();
                var item = await mock.GetItemAsync(id.ToString());
                if (item == null)
                {
                    await MessageService.ShowAsync("Proposta não encontrada");
                    return;
                }
                await MessageService.ShowAsync(item.Numero + item.Torre);
            }
            catch (Exception ex)
            {
                await MessageService.ShowAsync(ex.Message);
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}