using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.WeatherClient
{
    public class WeatherMap<T>
    {
       // private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string OpenWeatherApi2 = "http://api.openweathermap.org/data/2.5/weather?";
        private const string Key = "70239c1c9df186b32495ae0e57de9dde";
        HttpClient _httpClient = new HttpClient();

       /* public async Task<T> GetAllWeathers(string city)
        {
            var json = await _httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key);
            var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
            return getWeatherModels;
        }*/

        public async Task<T> GetAllWeathers(string lat, string lon)
        {
            var json = await _httpClient.GetStringAsync(OpenWeatherApi2 + "lat=" + lat + "&lon=" + lon + "&appid=" + Key);
            var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
            return getWeatherModels;
        }
    }
}
