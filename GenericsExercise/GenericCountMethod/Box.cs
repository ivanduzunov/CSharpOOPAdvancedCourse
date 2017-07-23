using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generic_Box_of_String
{
    public class Box<T>
        where T : IComparable<T>
    {
        public T value { get; set; }

        public Box(T element)
        {
            this.value = element;
        }

        public override string ToString()
        {
            return $"{value.GetType().FullName}: {value}";
        }

    }
}
