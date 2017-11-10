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
    public partial class Remote : ContentPage
    {
        public Remote()
        {
            InitializeComponent();
        }

        void OnTapBackRemote(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something

            Navigation.PopModalAsync();
        }
    }
}