using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class Threeuple<T, U, Z>
    {
        private T item1;
        private U item2;
        private Z item3;

        public Threeuple(T item1, U item2, Z item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }
        public U Item2
        {
            get { return item2; }
            set { item2 = value; }
        }
        public Z Item3
        {
            get { return item3; }
            set { item3 = value; }
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }

    }
}
