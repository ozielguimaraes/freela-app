using Prototipo.ViewModels;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Prototipo.Pages.About
{
    public class AboutPageModel : BasePageModel
    {
        public AboutPageModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}