using Prototipo.Services.Interfaces;
using System.Threading;

namespace Prototipo.iOS
{
    public class AppManager : IAppManager
    {
        public void Close()
        {
            Thread.CurrentThread.Abort();
        }
    }
}