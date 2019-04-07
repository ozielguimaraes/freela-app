using Prototipo.Models;
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
        public ICommand LoadItemsCommand { get; set; }

        public ListaPropostaPageModel()
        {
            Title = "Minhas Propostas";
            Items = new ObservableCollection<Models.Proposta>();
            LoadItemsCommand = new Command(async () => await LoadItems());
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
    }
}