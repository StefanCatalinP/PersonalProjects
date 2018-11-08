using System;
using Xamarin.Forms;

namespace AstrologyDoc
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }
        async void OnZodiac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zodiac());
        }
    }
}