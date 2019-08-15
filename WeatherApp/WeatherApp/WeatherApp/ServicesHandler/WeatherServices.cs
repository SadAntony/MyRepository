using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.WeatherClient;

namespace WeatherApp.ServicesHandler
{
    public class WeatherServices
    {
        WeatherMap<WeatherMainModel> _openWeatherRest = new WeatherMap<WeatherMainModel>();
       /* public async Task<WeatherMainModel> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(city);
            return getWeatherDetails;
        }*/

        public async Task<WeatherMainModel> GetWeatherDetails(string lat, string lon)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(lat,lon);
            return getWeatherDetails;
        }
    }
}
