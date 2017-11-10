using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pergamijn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inlogscherm : ContentPage
    {
        public Inlogscherm()
        {
            InitializeComponent();
        }

        void OnTapBackButtonInlogscherm(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PopModalAsync();
        }

        void OnTapFowardButtonInlogscherm(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            DisplayAlert("Pagina is niet goed",
                         "Jim heeft zijn pagina nog niet fatsoenlijk in elkaar gezet",
                         "Dan maar niet");
        }
    }
}