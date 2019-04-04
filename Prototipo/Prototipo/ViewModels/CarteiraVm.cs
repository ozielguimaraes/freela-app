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
            LoadDetailsCommand = new Command<Carteira>((carteira) =>  LoadDetails(carteira));
            IrParaPropostasCommand = new Command(async () => await IrParaPropostas());
        }


        private void LoadDetails(Carteira item)
        {
            Item = item;
        }

        private async Task IrParaPropostas()
        {
            await NavigationService.PushAsync(new NavigationPage(new PropostasPage()));
        }
    }
}