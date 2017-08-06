using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Shortage
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public int Food { get; private set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
