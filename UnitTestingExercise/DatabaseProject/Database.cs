using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class Database
    {
        private List<int> collection;
        private int currentIndex;

        public Database(string input)
        {

            this.collection = input.Split(' ').Select(int.Parse).ToList();
            currentIndex = collection.Count;
            for (int i = collection.Count; i < 16; i++)
            {
                collection.Add(default(int));
            }


        }

        public void Add(int element)
        {
            if (currentIndex == 16)
            {
                throw new InvalidOperationException("Cannod add more elements!");
            }
            collection[currentIndex] = element;
            currentIndex++;
        }

        public void Remove()
        {
            if (currentIndex == 0)
            {
                throw new InvalidOperationException("Database is empty!");
            }
            collection[currentIndex] = default(int);
            currentIndex--;
        }

        public int Capacity()
        {
            return collection.Count;
        }

        public int Count()
        {
            return currentIndex;
        }

    }
}
