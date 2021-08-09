using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Shop
    {
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            _warehouse = warehouse;
        }

        public Cart GetCart() => new Cart(_warehouse);
    }
}
