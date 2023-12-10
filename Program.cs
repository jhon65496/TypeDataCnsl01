using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDataCnsl01.ViewModels.Views;
// CultureInfo

namespace TypeDataCnsl01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cultureInfo = new CultureInfo("ru-RU");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            IndexesViewModel index = new IndexesViewModel();
        }
    }
}
