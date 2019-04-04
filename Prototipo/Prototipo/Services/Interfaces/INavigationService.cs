﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Services.Interfaces
{
    public interface INavigationService
    {
        void NavigateToUrl(string url);
        void MakePhoneCall(string number);
        Task PushModalAsync(Page page);
        Task PushAsync(Page page);
        Task PopAsync();
        Task PopToRootAsync();
        Task PopModalAsync();
        void RemovePage(Type type);
        void RemovePage(Page page);
        IList<Page> GetNavigationStack();
        Page GetCurrentPage();
        void NavigateOut();
    }
}