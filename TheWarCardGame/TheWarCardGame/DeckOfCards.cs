using System;
using System.Collections.Generic;
using System.Text;

namespace TheWarCardGame
{
    static class DeckOfCards
    {
        static private List<Card> playingCards;
        static public void createTheDeck()
        {
            playingCards = new List<Card>();

            for (int suit = (int)Card.SuitType.Spades; suit <= (int)Card.SuitType.Hearts;suit++)
            {
                for(int rank = (int)Card.CardRank.Ace; rank <=(int)Card.CardRank.King; rank++)
                {
                    Card card = new Card((Card.CardRank)rank,(Card.SuitType)suit);
                    playingCards.Add(card);
                }
            }//forSuit

        }//createTheDeck

        static public void ShuffleCards(int numberOfTimes)
        {
            int cardCount = playingCards.Count;
            Random drawRandom = new Random();

            for(int time = 0; time<=numberOfTimes; time++)
            {
                for(int index = 0; index<=cardCount; index++)
                {
                    int indPos = drawRandom.Next(cardCount);
                    Card temp = playingCards[indPos];
                }
            }



        }//shuffle
    }//DeckOfCards
}//nameSpace
