﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pergamijn
{
    public partial class YouTube : ContentPage
    {
        public YouTube()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognizerBack(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PopModalAsync();
        }

        void OnTapVideoYoutube(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PushAsync(new Videoplayer());
        }
    }
}
