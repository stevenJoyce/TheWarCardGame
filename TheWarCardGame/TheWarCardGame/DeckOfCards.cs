using System;
using System.Collections.Generic;
using System.Text;

namespace TheWarCardGame
{
     public class DeckOfCards
    {
         private List<Card> playingCards;
         private List<Card> firstPlayer;
         private List<Card> secondPlayer;


         public void CreateTheDeck()
        {
            playingCards = new List<Card>();
            firstPlayer = new List<Card>();
            secondPlayer = new List<Card>();


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
            //Call the dealDeck method to add to game
            DeckDeal();
        }//shuffle

        //Half the deck to deal to 2 players
        public void DeckDeal()
        {
            //populate player 1 and 2 with cards from deck after shuffled
            for (int i = 0; i<=26; i++)
            {
                firstPlayer.Add(playingCards[i]);
            }

            for(int i = 26; i< playingCards.Count;i++)
            {
                secondPlayer.Add(playingCards[i]);
            }
   

        }//deckDeal


    }//DeckOfCards
}//nameSpace
