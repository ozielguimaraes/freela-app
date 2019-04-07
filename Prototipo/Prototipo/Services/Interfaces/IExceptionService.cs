using System;
using System.Collections.Generic;

namespace Prototipo.Services.Interfaces
{
    public interface IExceptionService
    {
        void TrackError(string messageError);
        void TrackError(Exception ex);
        void TrackError(Exception e, string messageError);
        void TrackError(Exception e, Dictionary<string, string> properties);
    }
}