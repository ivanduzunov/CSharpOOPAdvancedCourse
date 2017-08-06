using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarhy.Interfaces
{
    public interface IInitialCollection<T>
    {
        IList<T> Collection { get; }
        int Add(T element);
    }
}
