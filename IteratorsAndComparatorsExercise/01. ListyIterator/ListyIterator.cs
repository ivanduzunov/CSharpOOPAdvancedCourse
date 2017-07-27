using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private readonly List<T> collection;
        private int currentIndex;


        public ListyIterator(params T[] data)
        {
            this.CurrentIndex = 0;
            this.collection = new List<T>(data);
        }

        public int CurrentIndex
        {
            get { return this.currentIndex; }
            set { this.currentIndex = value; }
        }

        public bool Move()
        {
            if (this.CurrentIndex < this.collection.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.CurrentIndex < this.collection.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (collection.Count > 0)
            {
                Console.WriteLine(collection[currentIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            
            for (int i = 0; i < collection.Count; i++)
            {
               yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
