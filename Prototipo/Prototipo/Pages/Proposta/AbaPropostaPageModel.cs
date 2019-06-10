using Prototipo.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public class AbaPropostaPageModel : BasePageModel
    {
        private ObservableCollection<PreChaveVm> items;

        public ICommand LoadPreChavesCommand { get; set; }
        public ICommand NovaPreChaveCommand { get; set; }
        public ICommand DeletePreChaveCommand { get; set; }

        private PreChaveVm _selectedItem;
        public PreChaveVm SelectedItem
        {
            get => null;
            set => SetProperty(ref _selectedItem, value);
        }

        private string empreendimento = "Selecione ...";
        public string Empreendimento
        {
            get { return empreendimento; }
            set { SetProperty(ref empreendimento, value); }
        }

        private ObservableCollection<string> listaEmpreendimento;
        public ObservableCollection<string> ListaEmpreendimento
        {
            get { return listaEmpreendimento; }
            set { SetProperty(ref listaEmpreendimento, value); }
        }

        private string torre;
        public string Torre
        {
            get { return torre; }
            set { SetProperty(ref torre, value); }
        }

        private ObservableCollection<string> listaTorre;
        public ObservableCollection<string> ListaTorre
        {
            get { return listaTorre; }
            set { SetProperty(ref listaTorre, value); }
        }

        private int unidade;
        public int Unidade
        {
            get { return unidade; }
            set { SetProperty(ref unidade, value); }
        }

        private ObservableCollection<int> listaUnidade;
        public ObservableCollection<int> ListaUnidade
        {
            get { return listaUnidade; }
            set { SetProperty(ref listaUnidade, value); }
        }

        private decimal valorVenda;
        public decimal ValorVenda
        {
            get { return valorVenda; }
            set { SetProperty(ref valorVenda, value); }
        }

        private PreChaveVm novaPreChave;
        public PreChaveVm NovaPreChave
        {
            get { return novaPreChave; }
            set { SetProperty(ref novaPreChave, value); }
        }

        private ObservableCollection<PreChaveVm> preChaves;
        public ObservableCollection<PreChaveVm> PreChaves
        {
            get { return preChaves; }
            set { SetProperty(ref preChaves, value); }
        }

        public AbaPropostaPageModel()
        {
            NovaPreChave = new PreChaveVm();
            PreChaves = new ObservableCollection<PreChaveVm>();
            LoadPreChavesCommand = new Command(async () => await LoadPreChaves());
            NovaPreChaveCommand = new Command(async () => await AdicionarNovaPreChave());
            DeletePreChaveCommand = new Command<PreChaveVm>(async (item) => await DeletePreChave(item));

            MockValues();
        }

        private async Task LoadPreChaves()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                PreChaves.Clear();

                foreach (var item in items)
                {
                    PreChaves.Add(item);
                }

                await Task.Delay(500);
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

        private async Task AdicionarNovaPreChave()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                if (NovaPreChave.QuantidadeParcelas <= 0)
                {
                    await MessageService.ShowAsync("Campo quantidade é obrigatório");
                    return;
                }
                if (NovaPreChave.Valor <= 0)
                {
                    await MessageService.ShowAsync("Campo valor é obrigatório");
                    return;
                }
                PreChaves.Add(NovaPreChave);
                NovaPreChave = new PreChaveVm();

                await Task.Delay(500);
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

        private async Task DeletePreChave(PreChaveVm item)
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                //TODO Deletar do servidor/api?
                PreChaves.Remove(item);

                await Task.Delay(500);
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

        private void MockValues()
        {
            items = new ObservableCollection<PreChaveVm>
                {
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 180,
                        Valor = 180000,
                        PrimeiroVencimento = DateTime.Now
                    }
                };

            ListaEmpreendimento = new ObservableCollection<string>
            {
                "Prime Village",
                "Jardim América",
                "Green Palace"
            };
        }
    }
}