﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Border_Control
{
    public class Citizen : ICitizen
    {
        public Citizen(string id, string name, int age, string birthdate)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; }
    }
}
