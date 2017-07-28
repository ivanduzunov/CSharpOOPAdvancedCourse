using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CardPower
{
    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;

        public Card(CardSuit suit, CardRank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {(int)this.rank + (int)this.suit}";
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }
            var firstResult = (int)this.rank + (int)this.suit;
            var secondResult = (int)other.rank + (int)other.suit;
            var rankComparison = firstResult.CompareTo(secondResult);
            return rankComparison;
        }
    }
}
