﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite
{
    public class Spy : ISoldier
    {
        public Spy(int id, string firstName, string lastName, string number)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
        }
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Number { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {Number.TrimStart(new char[] { '0' })}");
            return sb.ToString();
        }
    }
}
