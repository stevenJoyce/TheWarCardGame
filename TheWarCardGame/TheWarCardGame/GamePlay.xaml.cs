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
	public partial class GamePlay : ContentPage
	{
        //Call the DeckOfCards class and add to var
        DeckOfCards newDeck = new DeckOfCards();
		public GamePlay ()
		{
			InitializeComponent ();
            //Create deck 
            newDeck.CreateTheDeck();

            //shuffle deck
            newDeck.ShuffleCards(3);
		}



        //deal deck

      
        
    }
}