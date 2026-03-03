using Lab4;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            Console.WriteLine("\nПокупець у звичайному магазині (стандартне замовлення):");
            OrderCalculator order1 = new StandardOrder(new ShopImpl());
            order1.AddItem(1, 2);
            order1.AddItem(3, 5);
            order1.PrintOrder();

            Console.WriteLine("\nПокупець у звичайному магазині (замовлення з безкоштовною доставкою):");
            OrderCalculator order2 = new StandardOrder(new ShopImpl());
            order2.AddItem(2, 2);
            order2.AddItem(4, 2);
            order2.PrintOrder();

            Console.WriteLine("\nПокупець у іншому магазині (зі знижкою):");
            OrderCalculator order3 = new GiftOrder(new OtherShopImpl());
            order3.AddItem(1, 3);
            order3.AddItem(2, 1);
            order3.AddItem(4, 1);
            order3.PrintOrder();

            Console.WriteLine("\n\nПокупець у іншому магазині (подарункове замовлення, зі знижкою):");
            OrderCalculator order4 = new GiftOrder(new OtherShopImpl());
            order4.AddItem(1, 8);
            order4.AddItem(3, 2);
            order4.AddItem(4, 2);
            order4.PrintOrder();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[Помилка] {ex.Message}");
        }
    }
}
