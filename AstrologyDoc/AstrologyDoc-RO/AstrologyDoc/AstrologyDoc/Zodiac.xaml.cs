using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AstrologyDoc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    // reduce marimea aplicatiei si notifica cand apar unele erori
	public partial class Zodiac : ContentPage
	{
		public Zodiac ()
		{
			InitializeComponent ();
            // initilizare
		}
        async void OnAquarius(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aquarius());
        }
        // acelasi concept care ofera functionalitate butonului din UI la click
        async void OnAries(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aries());
        }

        async void OnCancer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cancer());
        }

        async void OnCapricorn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Capricorn());
        }

        async void OnGemini(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gemini());
        }

        async void OnLeo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leo());
        }

        async void OnLibra(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Libra());
        }

        async void OnPisces(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pisces());
        }

        async void OnSagittarius(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sagittarius());
        }

        async void OnScorpio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scorpio());
        }

        async void OnTaurus(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Taurus());
        }

        async void OnVirgo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Virgo());
        }


    }
}