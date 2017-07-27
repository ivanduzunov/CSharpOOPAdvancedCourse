using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private IList<T> collection;

        public CustomStack()
        {
            collection = new List<T>();
        }

        public void Push(params T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                collection.Add(data[i]);
            }
           
        }

        public void Pop()
        {
            if (collection.Count==0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                collection.RemoveAt(collection.Count - 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
