using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace Prototipo.Helpers
{
    public class PageHelper
    {
        public static void RegisterRoutes()
        {
            foreach (var item in GetPagesType())
            {
                Routing.RegisterRoute(item.FullName, item);
            }
        }

        private static void GetPageFromPageModel<T>(Type type) where T : class
        {
            var pageModel = $"{type.Name}Model";
        }

        private static List<Type> GetPagesType(string nameSpace = "Prototipo.Pages")
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => t != null && t.Namespace == nameSpace).ToList();
        }
    }
}