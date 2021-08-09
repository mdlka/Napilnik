using System;

namespace Napilnik
{
    class Store
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);

            GoodsView.Show(warehouse.Cells);

            Cart cart = shop.GetCart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            GoodsView.Show(cart.Cells);

            Console.WriteLine(cart.GetOrder().Paylink);
        }
    }
}
