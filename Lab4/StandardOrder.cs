using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class StandardOrder : OrderCalculator
    {
        public StandardOrder(ICalcImplementor impl) : base(impl) { }

        public override void AddItem(int productId, int quantity)
        {
            double unitPrice = _impl.GetUnitPrice(productId);
            _box.Add(new ItemInBox(productId, quantity) { Price = unitPrice });
        }

        public override double GetTotalPrice()
        {
            double subtotal = 0;
            foreach (var item in _box)
                subtotal += item.Price * item.Quantity;

            double delivery = _impl.GetDeliveryCost(subtotal);
            return Math.Round(subtotal + delivery, 2);
        }

        public override void PrintOrder()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"{"ID",-6} {"К-сть",-8} {"Ціна/од.",-12} {"Сума"}");
            Console.WriteLine(new string('-', 50));

            double subtotal = 0;
            foreach (var item in _box)
            {
                double lineTotal = item.Price * item.Quantity;
                subtotal += lineTotal;
                Console.WriteLine($"{item.Id,-6} {item.Quantity,-8} {item.Price,-12:F2} {lineTotal:F2} грн");
            }

            double delivery = _impl.GetDeliveryCost(subtotal);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"Підсумок:",-28} {subtotal:F2} грн");
            Console.WriteLine($"{"Доставка:",-28} {(delivery == 0 ? "безкоштовно" : delivery + " грн")}");
            Console.WriteLine($"{"Разом:",-28} {GetTotalPrice():F2} грн");
            Console.WriteLine(new string('=', 50));
        }

    }
}
