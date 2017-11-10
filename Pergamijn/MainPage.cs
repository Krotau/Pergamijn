using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pergamijn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnTapNetflix(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;

            Navigation.PushModalAsync(new Netflix());
        }

        void OnTapYoutube(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;

            Navigation.PushModalAsync(new YouTube());
        }

        void OnTapTv(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;

            Navigation.PushModalAsync(new Remote());
        }
    }
}
