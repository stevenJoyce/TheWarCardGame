using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheWarCardGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            //get new assembly
            var assembly = typeof(MainPage);

            string strLogo = "TheWarCardGame.Assets.Images.LogoApp.png";
            logoImage.Source = ImageSource.FromResource(strLogo, assembly);
        }
        private void BtnStart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Start());
        }
        private void BtnStats_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stats());
        }
        private void BtnSettings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }
    }
}
