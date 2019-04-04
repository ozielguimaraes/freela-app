using Prototipo.Services.Interfaces;

namespace Prototipo.Droid
{
    public class AppManager : IAppManager
    {
        public void Close()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}