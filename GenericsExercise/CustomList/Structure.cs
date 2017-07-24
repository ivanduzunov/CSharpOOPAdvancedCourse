using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Structure<T>
        where T : IComparable<T>
    {
        private IList<T> collection;

        public Structure()
        {
            this.collection = new List<T>();
        }

        public void Add(T element)
        {
            collection.Add(element);
        }
        public T Remove(int index)
        {
            T element = collection[index];
            collection.RemoveAt(index);
            return element;
        }
        public bool Contains(T element)
        {
            if (collection.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Swap(int index1, int index2)
        {
            T element1 = collection[index1];
            T element2 = collection[index2];
            collection[index1] = element2;
            collection[index2] = element1;
        }
        public int CountGreaterThan(T element)
        {
            var count = collection.Count(b => b.CompareTo(element) > 0);
            return count;
        }
        public T Max()
        {
            return collection.Max();
        }
        public T Min()
        {
            return collection.Min();
        }
        public IList<T> GetList()
        {
            return this.collection;
        }
    }
}
