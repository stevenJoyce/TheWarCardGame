using System;
using System.Collections.Generic;
using System.Text;

namespace TheWarCardGame
{
    public class Card
    {
        public Card(CardRank value, SuitType suit)
        {
            if (!Enum.IsDefined(typeof(SuitType), suit))
            {
                throw new ArgumentOutOfRangeException("suit");
            }
            if (!Enum.IsDefined(typeof(CardRank), value))
            {
                throw new ArgumentOutOfRangeException("rank");
            }
            Value = value;
            Suit = suit;

        }

        public enum SuitType
        {
            Spades, Clubs, Diamonds, Hearts
        }

        public enum CardRank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }


        public CardRank Value { get; set; }

        public SuitType Suit { get; set; }
    }
}
