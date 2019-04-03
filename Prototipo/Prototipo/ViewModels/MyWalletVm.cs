using Prototipo.Models;
using Prototipo.Services;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.Vms
{
    public class MyWalletVm : BaseVm
    {
        public MyWalletVm()
        {
            Title = "Minha Carteira";
            LoadDetailsCommand = new Command(async () => await LoadDetails());
        }

        public MyWallet Item { get; set; }
        public ICommand LoadDetailsCommand { get; set; }

        private async Task LoadDetails()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                var mock = new MyWalletMock();
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
    }
}