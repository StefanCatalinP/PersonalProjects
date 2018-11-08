using System;
using Xamarin.Forms;

namespace AstrologyDoc
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
            // initializare
        }
        async void OnZodiac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zodiac());
        }
        // event-ul la click pentru buton care ma duce spre Zodiac, asa se face Navigatia in Xamarin.forms/C# spre deosebire de Java.
    }
}