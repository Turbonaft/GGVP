using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetLibrary
{
    public abstract class FlowerBouquetFactory
    {
        protected abstract IFlowerBouquet CreateBouquet(string occasion);

        public IFlowerBouquet GetBouquet(string occasion)
        {
            return CreateBouquet(occasion);
        }
    }
}
