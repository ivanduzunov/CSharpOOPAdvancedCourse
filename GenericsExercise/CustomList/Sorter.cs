using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Sorter<T>
        where T : IComparable<T>
    {
        public static Structure<T> Sort(Structure<T> coll)

        {
            var list = coll.GetList().OrderBy(a => a).ToList();
            return new Structure<T>(list);
        }
    }
}
