using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetLibrary
{
    public class FuneralBouquet : IFlowerBouquet
    {
        public string GetBouquetDetails()
        {
            return "Похоронний букет: лілії, хризантеми.";
        }
    }
}
