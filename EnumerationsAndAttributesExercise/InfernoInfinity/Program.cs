    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity
{
    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class Program
    {
        public static void Main(string[] args)
        {

            Type type = typeof(Program);
            var attributeValues =
                typeof(Program).GetCustomAttributes(typeof(CustomAttribute), true).FirstOrDefault() as CustomAttribute;


            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                switch (input)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attributeValues.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attributeValues.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attributeValues.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attributeValues.Reviewers)}");
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
