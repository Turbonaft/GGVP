using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetLibrary
{
    public class WeddingBouquet : IFlowerBouquet
    {
        public string GetBouquetDetails()
        {
            return "Весільний букет: біла троянда, орхідеї.";
        }
    }
}
