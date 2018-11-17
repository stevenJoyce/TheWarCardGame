using System;
using System.Collections.Generic;
using System.Text;

namespace TheWarCardGame
{
     public class DeckOfCards
    {
         private List<Card> playingCards;

         public void CreateTheDeck()
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

        public void ShuffleCards(int numberOfTimes)
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
