using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingGenerics.BasicDataStructure
{
    internal class SimpleStackDouble
    {
        private readonly double[] _array;
        private int _index;

        public SimpleStackDouble(int quantity)
        {
            _index = -1;
            _array = new double[quantity];
        }

        public double Pop() => _array[_index--];
        public void Push(double value) => _array[++_index] = value;
        public int Count => _index + 1;
    }
}
