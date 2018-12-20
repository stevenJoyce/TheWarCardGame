using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheWarCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gameplay : ContentPage
    {
        private ImageSource cardImage;
        //Create variables to store card count
        public int player1CardCount;
        public int player2CardCount;
        private List<Card> player1Deck;
        private List<Card> player2Deck;
        public Gameplay()
        {
            InitializeComponent();
            SetUpImagesOnPage();
        }
        private void SetUpImagesOnPage()
        {
            //get new assembly
            var assembly = typeof(MainPage);

            string strcardBack = "TheWarCardGame.Assets.Images.Deck.blue_back.png";
            P1Deck.Source = ImageSource.FromResource(strcardBack, assembly);
            P2Deck.Source = ImageSource.FromResource(strcardBack, assembly);
        }
        private void DealBtn_Clicked(object sender, EventArgs e)
        {
            //Call the DeckOfCards class and add to var
            DeckOfCards newDeck = new DeckOfCards();
            //Create deck 
            newDeck.CreateTheDeck();

            //shuffle deck
            newDeck.ShuffleCards(3);

            player1Deck = newDeck.firstPlayer;
            player2Deck = newDeck.secondPlayer;

            var p1DeckCards = new Image { Source = cardImage };
            var p2DeckCards = new Image { Source = cardImage };

            P1Deck = p1DeckCards; 
            P2Deck = p2DeckCards;
        }

        //deal out the first two cards to be displayed

        //Store images into array
        public void CardID(Card card)
        {
            var Assembly = typeof(Gameplay);

            switch (card.Value)
            {
                case Card.CardRank.Ace:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.ClubsA.png", Assembly);
                                    break;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.DiamondsA.png", Assembly);
                                    break;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.HeartsA.png", Assembly);
                                    break;
                                }
                            case Card.SuitType.Spades:
                                {
                                    cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.SpadesA.png", Assembly);
                                    break;
                                }

                        }
                    }
                    break;
                case Card.CardRank.Two:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs2.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds2.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts2.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades2.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Three:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs3.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.DeckDiamonds3.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts3.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades3.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Four:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs4.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds4.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts4.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades4.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Five:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs5.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds5.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts5.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades5.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Six:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs6.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds6.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts6.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades6.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Seven:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs7.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds7.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts7.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades7.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Eight:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs8.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds8.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts8.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades8.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Nine:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs9.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds9.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts9.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades9.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Ten:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Clubs10.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Diamonds10.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Hearts10.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.Spades10.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Jack:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.ClubsJ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.DiamondsJ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.HeartsJ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.SpadesJ.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.Queen:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.ClubsQ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.DiamondsQ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.HeartsQ.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.SpadesQ.png", Assembly);
                                break;
                            }
                    }
                    break;
                case Card.CardRank.King:
                    switch (card.Suit)
                    {
                        case Card.SuitType.Clubs:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.ClubsK.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Diamonds:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.DiamondsK.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Hearts:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.HeartsK.png", Assembly);
                                break;
                            }
                        case Card.SuitType.Spades:
                            {
                                cardImage = ImageSource.FromResource("TheWarCardGame.Assets.Images.Deck.SpadesK.png", Assembly);
                                break;
                            }
                    }
                    break;
                default:
                    break;
            }//switch

        }//cardID

       
    }//class
}//namespace