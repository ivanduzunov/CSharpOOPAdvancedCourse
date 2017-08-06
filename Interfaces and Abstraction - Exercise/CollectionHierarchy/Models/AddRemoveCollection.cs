using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarhy.Interfaces;

namespace CollectionHierarhy.Models
{
    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        public IList<T> Collection { get; }

        public AddRemoveCollection()
        {
            this.Collection = new List<T>();
        }
        public int Add(T element)
        {
            IList<T> temporary = Collection.ToList();
            Collection.Clear();
            Collection.Add(element);
            foreach (T item in temporary)
            {
                Collection.Add(item);
            }

            return 0;
        }

        public T Remove()
        {
            T toReturn = Collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count - 1);

            return toReturn;
        }
    }
}
