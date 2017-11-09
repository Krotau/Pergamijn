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

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PopModalAsync();
        }

    }
}
