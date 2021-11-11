using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingGenerics.BasicDataStructure
{
    //generic type can use any name like <TItem>
    internal class SimpleStack<T> 
    {
        private readonly T[] _array;
        private int _index;

        public SimpleStack(int quantity)
        {
            _index = -1;
            _array = new T[quantity];
        }

        public T Pop() => _array[_index--];
        public void Push(T value) => _array[++_index] = value;
        public int Count => _index + 1;
    }
}
