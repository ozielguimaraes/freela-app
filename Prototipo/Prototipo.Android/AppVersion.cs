using Prototipo.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(Prototipo.Droid.AppVersion))]
namespace Prototipo.Droid
{
    public class AppVersion : IAppVersion
    {
        public string GetVersion()
        {
            var context = Android.App.Application.Context;

            var manager = context.PackageManager;
            var info = manager.GetPackageInfo(context.PackageName, 0);

            return info.VersionName;
        }

        public int GetBuild()
        {
            var context = Android.App.Application.Context;
            var manager = context.PackageManager;
            var info = manager.GetPackageInfo(context.PackageName, 0);

            return info.VersionCode;
        }
    }
}