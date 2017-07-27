using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
       

        public Person(List<string> tokens)
        {
            this.Name = tokens[0];
            this.Age = int.Parse(tokens[1]);
            this.Town = tokens[2];
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person otherPerson)
        {

            if (this.Name != otherPerson.Name)
            {
                return this.Name.CompareTo(otherPerson.Name);
            }

            if (this.Age != otherPerson.Age)
            {
                return this.Age.CompareTo(otherPerson.Age);
            }

            return this.Town.CompareTo(otherPerson.Town);
        }

    }
}
