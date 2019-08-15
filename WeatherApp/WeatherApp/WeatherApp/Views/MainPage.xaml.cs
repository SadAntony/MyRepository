using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if(!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Error", "Check your internet connection", "OK");
            }
                
        }

        public async void ClickedGPS(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;

            Position position = await locator.GetPositionAsync();
            LatitudeLabel.Text = position.Latitude.ToString();
            LongitudeLabel.Text = position.Longitude.ToString();
        }
    }
}
