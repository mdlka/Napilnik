using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Warehouse : IGoodsProvider
    {
        private readonly Storage _storage;

        public Warehouse()
        {
            _storage = new Storage();
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _storage.Cells;

        public void Delive(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            _storage.Add(good, count);
        }

        public bool Has(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return _storage.Has(good, count);
        }

        public void Extract(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (Has(good, count) == false)
                throw new InvalidOperationException();

            _storage.Extract(good, count);
        }
    }
}
