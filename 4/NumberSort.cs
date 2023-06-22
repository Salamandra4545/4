using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class OldeerSort<T> : IComparer
    {

        public OldeerSort()
        {

        }

        public int Compare(object? x, object? y)
        {

            if (x is Train Train1 && y is Train Train2)
            {
                int first = int.Parse(Train1.NumberTrain);
                int second = int.Parse(Train2.NumberTrain);
                if (first > second) return 1;
                else if (first < second) return -1;
                return 0;

            }
            throw new Exception("Невозможно сравнить");
        }
    }
}
