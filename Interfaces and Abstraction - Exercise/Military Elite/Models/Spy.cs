using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.Military_Elite.Interfaces;

namespace _08.Military_Elite
{
    public class Spy : ISpy
    {
        public Spy(int id, string firstName, string lastName, int number)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
        }
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Number { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {Number}");
            return sb.ToString().Trim();
        }
    }
}
