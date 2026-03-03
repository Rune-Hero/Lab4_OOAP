using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface ICalcImplementor
    {
        double GetUnitPrice(int productId);
        double GetDeliveryCost(double total);
    }
}
