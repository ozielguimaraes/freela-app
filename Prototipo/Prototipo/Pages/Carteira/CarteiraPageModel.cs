using Prototipo.Pages.Proposta;
using Prototipo.Services.Mocks;
using Prototipo.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Pages.Carteira
{
    public class CarteiraPageModel : BasePageModel
    {
        public ICommand LoadDetailsCommand { get; set; }
        public ICommand IrParaPropostasCommand { get; set; }

        Models.Carteira item;
        public Models.Carteira Item
        {
            get { return item; }
            set { SetProperty(ref item, value); }
        }

        public CarteiraPageModel()
        {
            Title = "Minha Carteira";
            LoadDetailsCommand = new Command(() => LoadDetails());
            IrParaPropostasCommand = new Command(async () => await IrParaPropostas());
        }

        private async void LoadDetails()
        {
            var mock = new CarteiraMock();
            var item = await mock.GetItemAsync(string.Empty);
            Item = item;
        }

        private async Task IrParaPropostas()
        {
            await NavigationService.PushModalAsync(new NavigationPage(new ListaPropostaPage()));
        }
    }
}