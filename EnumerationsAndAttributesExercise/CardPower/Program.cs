using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CardsCompare();
        }

        public static void CardsCompare()
        {
            var rankInput = Console.ReadLine();
            var suitInput = Console.ReadLine();
            CardRank rank = (CardRank)Enum.Parse(typeof(CardRank), rankInput);
            CardSuit suit = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput);
            Card cardOne = new Card(suit, rank);
            var rankInput2 = Console.ReadLine();
            var suitInput2 = Console.ReadLine();
            CardRank rank2 = (CardRank)Enum.Parse(typeof(CardRank), rankInput2);
            CardSuit suit2 = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput2);
            Card cardTwo = new Card(suit2, rank2);
            List<Card> cards = new List<Card>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            Card resultCard = cards.OrderByDescending(c => c).First();
            Console.WriteLine(resultCard.ToString());
        }
    }
}
