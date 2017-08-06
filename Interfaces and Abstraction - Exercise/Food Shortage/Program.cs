using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Shortage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            var n = int.Parse(Console.ReadLine());
            var input = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                if (tokens.Length == 4)
                {
                    buyers.Add(tokens[0],
                        new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else
                {
                    buyers.Add(tokens[0],
                        new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }
            }
            Console.WriteLine(buyers.Values.Sum(v => v.Food));
        }
    }
}
