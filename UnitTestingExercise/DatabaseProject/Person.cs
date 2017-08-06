using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class Person
    {
        private string id;
        private string username;

        public Person(string id, string username)
        {
            Id = id;
            Username = username;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
