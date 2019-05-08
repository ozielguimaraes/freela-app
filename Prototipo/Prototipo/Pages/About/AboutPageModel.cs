using Prototipo.ViewModels;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Prototipo.Pages.About
{
    public class AboutPageModel : BasePageModel
    {
        public ICommand OpenDeveloperProfileCommand { get; }

        public AboutPageModel()
        {
            OpenDeveloperProfileCommand = new Command(() => Device.OpenUri(new Uri("https://www.linkedin.com/in/ozielguimaraes")));
        }
    }
}