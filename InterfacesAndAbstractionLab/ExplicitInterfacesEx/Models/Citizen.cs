using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ExplicitInterfacesEx.Interfaces;

namespace ExplicitInterfacesEx.Models
{
    public class Citizen : IResident, IPerson
    {
        private string residentName;
        private string personName;

        public Citizen(string name, string country, int age)
        {
            this.personName = name;
            this.residentName = $"Mr/Ms/Mrs {name}";
            this.Country = country;
            this.Age = age;
        }

        string IResident.Name
        {
            get => this.residentName;
        }

        public int Age { get; }

        void IPerson.GetName()
        {
            Console.WriteLine(this.personName);
        }

        public string Country { get; }

        string IPerson.Name
        {
            get => this.personName;
        }

        void IResident.GetName()
        {
            Console.WriteLine(this.residentName);
        }
    }
}
