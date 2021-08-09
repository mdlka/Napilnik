using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Order
    {
        private readonly string _paylink;

        public Order()
        {
            _paylink = "ff0a35abd3d14a56159ceb5dcb9657df";
        }

        public string Paylink => _paylink;
    }
}
