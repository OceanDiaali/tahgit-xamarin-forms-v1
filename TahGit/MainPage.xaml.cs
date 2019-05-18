using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TahGit
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        //string amountVal;

        public MainPage()
        {
            InitializeComponent();

            Title = "TahGit";

        }

        void Button_Clicked(object sender, EventArgs e) {

            var amountVal = Amount.Text;
            var timeVal = Duration.Text;

            Navigation.PushAsync(new TahgitPage(amountVal, timeVal));
        }

    }
}
