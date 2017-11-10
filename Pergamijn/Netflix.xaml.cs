using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Pergamijn
{
    public partial class Netflix : ContentPage
    {
        public Netflix()
        {
            InitializeComponent();

        }

        void OnTapVideoplayer(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PushModalAsync(new Videoplayer());
        }


        void OnTapBackButton(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PopModalAsync();
        }

    }
}
