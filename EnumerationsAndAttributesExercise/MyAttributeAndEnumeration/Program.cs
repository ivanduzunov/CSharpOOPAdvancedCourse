using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributeAndEnumeration
{
    [MySample("Noodles", "08.08.2017")]
    public class Program
    {
        public static void Main(string[] args)
        {
            var attributeValues = (MySampleAttribute)typeof(Program).GetCustomAttributes(typeof(MySampleAttribute), true).FirstOrDefault();
            Console.WriteLine($"Program class: Author: {attributeValues.Author}, Date: {attributeValues.DateMade}");
            Console.WriteLine("Content: None");

            var enumAttributeValues = (MySampleAttribute)typeof(Seasons).GetCustomAttributes(typeof(MySampleAttribute), true).FirstOrDefault();
            Console.WriteLine($"Seasons Enumeration: Author: {enumAttributeValues.Author}, Date: {enumAttributeValues.DateMade}");
            Console.WriteLine("Content:");


            var values = Enum.GetValues(typeof(Seasons));
            Seasons winter = (Seasons)Enum.Parse(typeof(Seasons), "Winter");
            Console.WriteLine(winter);
            foreach (var season in values)
            {
                Console.WriteLine($"{season} => {(int)season}");
            }


        }
    }
}
