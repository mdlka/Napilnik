using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    interface IGoodsProvider
    {
        bool Has(Good good, int count);

        void Extract(Good good, int count);
    }
}
