using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class GoodsView
    {
        public static void Show(IReadOnlyList<IReadOnlyCell> cells)
        {
            foreach (var cell in cells)
            {
                Console.WriteLine($"{cell.Good.Name} - {cell.Count}");
            }
        }
    }
}
