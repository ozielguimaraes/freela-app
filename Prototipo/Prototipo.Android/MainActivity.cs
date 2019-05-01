using FFImageLoading.Forms.Platform;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Xamarin.Forms;

namespace Prototipo.Droid
{
    [Activity(Label = "Prototipo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public MainActivity()
        {
            AppCompatDelegate.CompatVectorFromResourcesEnabled = true;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            CachedImageRenderer.Init(true);
            Forms.Init(this, savedInstanceState);
            var xfApplication = new App();
#if DEBUG
            HotReloader.Current.Start(xfApplication, 4290);
#endif
            LoadApplication(xfApplication);
        }
    }
}