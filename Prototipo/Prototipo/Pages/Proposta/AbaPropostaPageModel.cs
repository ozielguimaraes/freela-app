using Prototipo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public class AbaPropostaPageModel : BasePageModel
    {
        private readonly List<PreChaveVm> items;

        public ICommand LoadPreChavesCommand { get; set; }
        public ICommand NovaPreChaveCommand { get; set; }

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

            items = new List<PreChaveVm>
                {
                    //new PreChaveVm
                    //{
                    //    QuantidadeParcelas = 86,
                    //    Valor = 40908,
                    //    PrimeiroVencimento = DateTime.Now
                    //},
                    //new PreChaveVm
                    //{
                    //    QuantidadeParcelas = 86,
                    //    Valor = 40908,
                    //    PrimeiroVencimento = DateTime.Now
                    //},
                    //new PreChaveVm
                    //{
                    //    QuantidadeParcelas = 86,
                    //    Valor = 40908,
                    //    PrimeiroVencimento = DateTime.Now
                    //},
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 180,
                        Valor = 180000,
                        PrimeiroVencimento = DateTime.Now
                    }
                };
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
    }
}