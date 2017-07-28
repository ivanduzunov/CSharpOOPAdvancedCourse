using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSuit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "Card Suits")
            {
                PrintSuit(input);
            }
            else
            {
                PrintRank(input);
            }
        }

        public static void PrintSuit(string input)
        {
            Console.WriteLine($"{input}:");
            Array ranks = Enum.GetValues(typeof(CardSuit));

            foreach (var card in ranks)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
        public static void PrintRank(string input)
        {
            Console.WriteLine($"{input}:");
            Array ranks = Enum.GetValues(typeof(CardRank));

            foreach (var card in ranks)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }





        }
    }
}
