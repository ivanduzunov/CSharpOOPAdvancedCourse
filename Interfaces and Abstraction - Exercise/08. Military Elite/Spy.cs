using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite
{
    public class Spy : ISoldier
    {
        public Spy(string id, string firstName, string lastName, int number)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
        }
        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Number { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {Number}");
            return sb.ToString();
        }
    }
}
