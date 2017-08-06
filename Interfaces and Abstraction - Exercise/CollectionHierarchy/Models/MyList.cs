using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarhy.Interfaces;

namespace CollectionHierarhy.Models
{
    public class MyList<T> : IMyList<T>
    {
        public MyList()
        {
            this.Collection = new List<T>();
        }

        public IList<T> Collection { get; private set; }

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
            T toReturn = Collection[0];
            Collection.RemoveAt(0);

            return toReturn;
        }

        public int Used()
        {
            return Collection.Count;
        }
    }
}
