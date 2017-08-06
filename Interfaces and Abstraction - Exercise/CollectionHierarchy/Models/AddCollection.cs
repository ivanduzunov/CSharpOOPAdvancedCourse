using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarhy.Interfaces;

namespace CollectionHierarhy.Models
{
    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Collection = new List<T>();
        }

        public IList<T> Collection { get; private set; }

        public int Add(T element)
        {
            Collection.Add(element);

            return Collection.Count - 1;
        }
       
    }
}
