using Prototipo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Views
{
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Carteira, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Carteira:
                        MenuPages.Add(id, new NavigationPage(new CarteiraPage()));
                        break;
                    case (int)MenuItemType.Proposta:
                        MenuPages.Add(id, new NavigationPage(new PropostasPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}