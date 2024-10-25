using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetLibrary
{
    public class BouquetFactory : FlowerBouquetFactory
    {
        protected override IFlowerBouquet CreateBouquet(string occasion)
        {
            switch (occasion)
            {
                case "Birthday":
                    return new BirthdayBouquet();
                case "Wedding":
                    return new WeddingBouquet();
                case "Funeral":
                    return new FuneralBouquet();
                default:
                    throw new ArgumentException("Невідома подія");
            }
        }
    }
}
