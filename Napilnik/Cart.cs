using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Cart
    {
        private readonly Storage _storage;
        private readonly IGoodsProvider _goodsProvider;

        public Cart(IGoodsProvider goodsProvider)
        {
            if (goodsProvider == null)
                throw new ArgumentNullException(nameof(goodsProvider));

            _storage = new Storage();
            _goodsProvider = goodsProvider;
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _storage.Cells;

        public Order GetOrder() => new Order();

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_goodsProvider.Has(good, count) == false)
                throw new InvalidOperationException("Goods are not enough");

            _goodsProvider.Extract(good, count);
            _storage.Add(good, count);
        }
    }
}
