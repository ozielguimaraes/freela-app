using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo.ViewModels
{
    public class MenuItemVm
    {
        public MenuItemVm(string title, string icon, MenuType type)
        {
            Title = title;
            Icon = icon;
            Type = type;
        }

        public string Title { get; private set; }
        public string Icon { get; private set; }
        public MenuType Type { get; private set; }
    }
}

public enum MenuType
{
    Carteira,
    Proposta,
    Empreendimento,
    GravarProposta,
    About
}