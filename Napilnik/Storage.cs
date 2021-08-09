using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napilnik
{
    class Storage : IGoodsProvider
    {
        private readonly List<Cell> _cells;

        public Storage()
        {
            _cells = new List<Cell>();
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Cell newCell = new Cell(good, count);

            if (TryGetCell(good, out Cell cell))
                cell.Merge(newCell);
            else
                _cells.Add(newCell);
        }

        public bool Has(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (TryGetCell(good, out Cell cell))
                return cell.Count >= count;

            return false;
        }

        public void Extract(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (Has(good, count) == false)
                throw new InvalidOperationException();

            if (TryGetCell(good, out Cell cell))
                cell.Remove(count);
        }

        private bool TryGetCell(Good good, out Cell cell)
        {
            cell = _cells.FirstOrDefault(cell => cell.Good == good);

            return cell != null;
        }
    }
}
