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
    public partial class Start : ContentPage
    {

        private void DealBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePlay());
        }//btn
    }//start
    
}