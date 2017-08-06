using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class PeopleDatabase
    {
        private List<Person> peopleList;
        private int currentIndex;

        public PeopleDatabase()
        {
            peopleList = new List<Person>();
        }

        public void Add(Person person)
        {
            if (peopleList.Where(p => p.Username == person.Username).Count() > 0)
            {
                throw new InvalidOperationException("There are already person with this username in the database!");
            }
            if (peopleList.Where(p => p.Id == person.Id).Count() > 0)
            {
                throw new InvalidOperationException("There are already person with this ID in the database!");
            }

            peopleList.Add(person);
            currentIndex++;
        }

        public void Remove()
        {
            if (currentIndex == 0)
            {
                throw new InvalidOperationException("Database is empty");
            }

            peopleList.RemoveAt(currentIndex - 1);
            currentIndex--;
        }

        public Person FindByUsername(string username)
        {
            if (peopleList.Where(p => p.Username == username).Count() == 0)
            {
                throw new InvalidOperationException("There are no person with this Username!");
            }
            Person pson = peopleList.Where(p => p.Username == username).First();
            return pson;
        }

        public Person FindById(string id)
        {
            if (peopleList.Where(p => p.Id == id).Count() == 0)
            {
                throw new InvalidOperationException("There are no person with this ID!");
            }
            Person pson = peopleList.Where(p => p.Id == id).First();
            return pson;
        }

        public int Count()
        {
            return peopleList.Count;
        }
    }
}
