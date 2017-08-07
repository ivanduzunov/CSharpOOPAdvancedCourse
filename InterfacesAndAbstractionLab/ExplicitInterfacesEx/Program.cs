using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExplicitInterfacesEx.Interfaces;
using ExplicitInterfacesEx.Models;

namespace ExplicitInterfacesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();
                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                IPerson cznP = new Citizen(name, country, age);
                IResident cznR = new Citizen(name, country, age);

                cznP.GetName();
                cznR.GetName();
            }
        }
    }
}
