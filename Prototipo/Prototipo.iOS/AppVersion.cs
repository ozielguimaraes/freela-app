using Prototipo.iOS;
using Prototipo.Services.Interfaces;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(AppVersion))]
namespace Prototipo.iOS
{
    public class AppVersion : IAppVersion
    {
        public string GetVersion()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }

        public int GetBuild()
        {
            return int.Parse(NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString());
        }
    }
}