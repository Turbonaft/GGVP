using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetLibrary
{
    public class BirthdayBouquet : IFlowerBouquet
    {
        public string GetBouquetDetails()
        {
            return "Букет на день народження: троянди, лілії, гвоздики.";
        }
    }
}
