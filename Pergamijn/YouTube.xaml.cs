using System;
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

        void OnTapGestureGoBack(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

        void OnTapVideoYoutube(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Videoplayer());
        
        }
    }
}
