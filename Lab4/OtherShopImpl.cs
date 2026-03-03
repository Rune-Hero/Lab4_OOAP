using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class OtherShopImpl : ICalcImplementor
    {
        private readonly ShopImpl _base = new();

        public double GetUnitPrice(int productId)
        {
            return Math.Round(_base.GetUnitPrice(productId) * 0.8, 2);
        }

        public double GetDeliveryCost(double total)
        {
            return 0;
        }
    }
}
