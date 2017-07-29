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
            DeckOfCards();
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
        public static void DeckOfCards()
        {
            var ranks = Enum.GetNames(typeof(CardRank));
            var suits = Enum.GetNames(typeof(CardSuit));

            

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
