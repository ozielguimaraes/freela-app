using Prototipo.Services.Interfaces;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prototipo.ViewModels
{
    public class BasePageModel : ObservableObject
    {
        protected IExceptionService ExceptionService;
        public IMessageService MessageService;
        public INavigationService NavigationService;

        public ICommand OnMenuItemSelectedCommand { get; set; }

        public BasePageModel()
        {
            IsPresented = false;
            IsLoading = false;
            Title = Constants.AppName;
            AppName = Constants.AppName;
            ExceptionService = DependencyService.Get<IExceptionService>();
            MessageService = DependencyService.Get<IMessageService>();
            NavigationService = DependencyService.Get<INavigationService>();
            AppVersion = DependencyService.Get<IAppVersion>().GetVersion();
        }

        public string AppName { get; set; }
        public string AppVersion { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        private bool _isPresented;
        public bool IsPresented
        {
            get => _isPresented;
            set => SetProperty(ref _isPresented, value);
        }

        #region IDisposable Members
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                // Set the _disposed flag to prevent subsequent disposals.
                _disposed = true;
            }
        }

        ~BasePageModel()
        {
            Dispose(false);
        }

        #endregion
    }
}