﻿using System;
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

        void OnTapBackButton(object sender, EventArgs args){
            var imageSender = (Image)sender;

            Navigation.PopModalAsync();
        }

        void OnTapForwardButton(object sender, EventArgs args){
            var imageSender = (Image)sender;

            Navigation.PushModalAsync(new SettingsFilms());
        }
    }
}