using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class OrderCalculator
    {
        protected ICalcImplementor _impl;
        protected List<ItemInBox> _box = new();

        protected OrderCalculator(ICalcImplementor impl)
        {
            _impl = impl;
        }

        public abstract void AddItem(int productId, int quantity);
        public abstract double GetTotalPrice();
        public abstract void PrintOrder();
    }
}
