using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ClassContainer
{
    public static class Helper
    {
        public static bool IsWindowOpened<T>()
        {
            if (System.Windows.Application.Current.Windows.OfType<T>().Any())
                return true;
            return false;
        }

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static ObservableCollection<T> Convert<T>(IEnumerable<T> original)
        {
            return new ObservableCollection<T>(original);
        }
    }
}
