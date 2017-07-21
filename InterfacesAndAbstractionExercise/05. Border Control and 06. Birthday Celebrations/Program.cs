using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Border_Control
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IBirthtable> entities = new List<IBirthtable>();


            var input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Citizen")
                {
                    entities.Add(new Citizen(tokens[3], tokens[1],
                        int.Parse(tokens[2]), tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    entities.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            var year = Console.ReadLine().Trim();

            foreach (var entity in entities)
            {
                var check = entity.Birthdate.Split('/').ToList();
                if (check[2] == year)
                {
                    Console.WriteLine(entity.Birthdate);
                }

            }
        }
    }
}
