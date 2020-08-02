using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather_Blazor.Data
{
    public class WeatherForecastService
    {
        
            public static async Task<WeatherForecast> LoadWeatherForecast()
            {
                string url = "http://api.openweathermap.org/data/2.5/weather?q=Melbourne,AU&units=metric&appid=09ea3f65a17d62173f1048806b078ff4";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // getting the Main model 
                        MainModel main = await response.Content.ReadAsAsync<MainModel>();

                        // only returning the Main property in MainModel
                        return main.Main;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
        }
    }

