using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Cell : IReadOnlyCell
    {
        public Cell(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Good = good;
            Count = count;
        }

        public Good Good { get; private set; }
        public int Count { get; private set; }

        public void Merge(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }

        public void Remove(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (Count - count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Count -= count;
        }
    }

    interface IReadOnlyCell
    {
        Good Good { get; }
        int Count { get; }
    }
}
