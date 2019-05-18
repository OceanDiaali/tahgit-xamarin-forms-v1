using System;
//using System.Collections.Generic;

using Xamarin.Forms;

namespace TahGit
{
    public partial class TahgitPage : ContentPage
    {
        public string AmtValue { get; }
        public string TimeValue { get; }
        public string RemainderValue { get; set; }


        double money, period, calc;
        string result;

        public TahgitPage(string aVal, string tVal)
        {

            AmtValue = aVal + " Naira";
            TimeValue = tVal + " days";

            money = Convert.ToDouble(aVal);
            period = Convert.ToDouble(tVal);

            calc = (money / period);
            result = Math.Floor(calc).ToString();
            //result =  calc.ToString("G2");

            RemainderValue = "You need to save " + result + " Naira everyday";

            BindingContext = this;
            InitializeComponent();
            Title = "Details";

            //region toolbar
            ToolbarItem tbi = null;

                tbi = new ToolbarItem("+", "plus",  () =>
                {

                }, 0, 0);
            
            ToolbarItems.Add(tbi);
            //endregion
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs e) {
            HourGlass.RotateTo(360, 2000);
            HourGlass.Rotation = 0;
            Calendarium.IsVisible = true;
        }

    } // class
} // namespace
