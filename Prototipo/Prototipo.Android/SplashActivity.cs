using Android.App;
using Android.Support.V7.App;
using Xamarin.Forms.Internals;

namespace Prototipo.Droid
{
    [Preserve(AllMembers = true)]
    [Activity(
           Label = Constants.AppName,
           Icon = "@drawable/icon",
           Theme = "@style/splashscreen",
           MainLauncher = true,
           NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}