using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingGenerics
{
    internal class GenericRepository<TItem, TKey, TSecret> //where TItem : class, IEquatable<TItem>, new()
    {
        List<TItem> _items;

        //public TItem? GetById(int id)
        //{
        //    return null;
        //}

        public GenericRepository()
        {
            _items = new List<TItem>();
        }

        public void Add(TItem item)
        {
            _items.Add(item);
        }

        //remove
        public void Remove(TItem item)
        {
            if (_items.Remove(item))
                Console.WriteLine("Remove!");
            else
                Console.WriteLine("Not removed!");
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
