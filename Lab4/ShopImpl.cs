using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ShopImpl : ICalcImplementor
    {
        private readonly Dictionary<int, double> _catalog = new()
        {
            { 1, 100.00 },
            { 2, 250.50 },
            { 3,  75.00 },
            { 4, 499.99 },
        };


        public double GetUnitPrice(int productId)
        {
            if (_catalog.TryGetValue(productId, out double price)) 
                return price;
            throw new Exception($"Товар з ID={productId} не знайдено у каталозі.");
        }

        public double GetDeliveryCost(double total)
        {
            return total >= 1000 ? 0 : 70;
        }
    }
}
