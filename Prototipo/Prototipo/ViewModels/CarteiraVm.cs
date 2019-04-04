using Prototipo.Models;
using Prototipo.Services;
using Prototipo.Views;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.ViewModels
{
    public class CarteiraVm : BaseVm
    {
        public ICommand LoadDetailsCommand { get; set; }
        public ICommand IrParaPropostasCommand { get; set; }
        public Carteira Item { get; set; }

        public CarteiraVm()
        {
            Title = "Minha Carteira";
            LoadDetailsCommand = new Command(async () => await LoadDetails());
            IrParaPropostasCommand = new Command(async () => await IrParaPropostas());
        }


        private async Task LoadDetails()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                var mock = new CarteiraMock();
                Item = await mock.GetItemAsync(string.Empty);
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

        private async Task IrParaPropostas()
        {
            await NavigationService.PushAsync(new PropostasPage());
        }
    }
}