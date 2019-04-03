using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Prototipo.Vms
{
    public class AboutVm : BaseVm
    {
        public AboutVm()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}