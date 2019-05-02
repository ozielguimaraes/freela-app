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
        public ICommand LoadPreChavesCommand { get; set; }

        private ObservableCollection<PreChaveVm> preChaves;
        public ObservableCollection<PreChaveVm> PreChaves
        {
            get { return preChaves; }
            set { SetProperty(ref preChaves, value); }
        }

        public AbaPropostaPageModel()
        {
            PreChaves = new ObservableCollection<PreChaveVm>();
            LoadPreChavesCommand = new Command(async () => await LoadPreChaves());
        }

        private async Task LoadPreChaves()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                PreChaves.Clear();
                var items = new List<PreChaveVm>
                {
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 86,
                        Valor = 40908,
                        PrimeiroVencimento = DateTime.Now
                    },
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 86,
                        Valor = 40908,
                        PrimeiroVencimento = DateTime.Now
                    },
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 86,
                        Valor = 40908,
                        PrimeiroVencimento = DateTime.Now
                    },
                    new PreChaveVm
                    {
                        QuantidadeParcelas = 180,
                        Valor = 180000,
                        PrimeiroVencimento = DateTime.Now
                    }
                };

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
    }
}