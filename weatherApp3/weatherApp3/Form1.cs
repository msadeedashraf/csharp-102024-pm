using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace weatherApp3
{
    public partial class Form1 : Form
    {

        public class WeatherResponse
        {
            public Coord Coord { get; set; }
            public Weather[] Weather { get; set; }
            public string Base { get; set; }
            public Main Main { get; set; }
            public int Visibility { get; set; }
            public Wind Wind { get; set; }
            public Rain Rain { get; set; }
            public Clouds Clouds { get; set; }
            public long Dt { get; set; }
            public Sys Sys { get; set; }
            public int Timezone { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cod { get; set; }
        }

        public class Coord
        {
            public double Lon { get; set; }
            public double Lat { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public double Feels_Like { get; set; }
            public double Temp_Min { get; set; }
            public double Temp_Max { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public int Sea_Level { get; set; }
            public int Grnd_Level { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            public int Deg { get; set; }
            public double Gust { get; set; }
        }

        public class Rain
        {
            [JsonPropertyName("1h")]
            public double One_Hour { get; set; } // Matches "1h" if present
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Sys
        {
            public int Type { get; set; }
            public int Id { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }



        public Form1()
        {
            InitializeComponent();
            lbl_c.Visible = false;
            lbl_o.Visible = false;
            lbl_temp.Visible = false;
            lbl_err.Visible = false;

        }

        string APIKey = "e6371e622ecf5ce41a555eb7a5dd5d94";
        
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            string city = txt_city.Text;
             getWeatherAsync(city, APIKey);
           
        }




        DateTime convertDateTime(long sec)
        {
            /*DateTime day = DateTime.Now;
            day = day.AddSeconds(sec); */

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }


        async Task getWeatherAsync(string city, string apiKey)
        {

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(url);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string jsonResponse  = await responseMessage.Content.ReadAsStringAsync();


                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true // Allow case-insensitive mapping
                        };


                        var weatherData = JsonSerializer.Deserialize<WeatherResponse>(jsonResponse, options);


                        if (weatherData != null && weatherData.Main != null)
                        {
                            
                            lbl_conditions.Text = weatherData.Weather[0].Main;
                            lbl_sunrise.Text = convertDateTime(weatherData.Sys.Sunrise).ToShortTimeString() ;
                            lbl_sunset.Text =  convertDateTime(weatherData.Sys.Sunset).ToShortTimeString();
                            lbl_details.Text = weatherData.Weather[0].Description;
                            lbl_pressure.Text = weatherData.Main.Pressure.ToString();
                            lbl_wind_speed.Text = weatherData.Wind.Speed.ToString();
                            pic_temp.ImageLocation = "https://openweathermap.org/img/w/" + weatherData.Weather[0].Icon+ ".png";
                            double tempConvert = weatherData.Main.Temp - 273.15;
                            lbl_temp.Text = tempConvert.ToString("F1");
                            //lbl_temp.Text = $"{weatherData.Main.Temp - 273.15:F2}"; // Convert from Kelvin to Celsius


                            lbl_c.Visible = true;
                            lbl_o.Visible = true;
                            lbl_temp.Visible = true;
                        }
                        else
                        {
                            lbl_err.Text = "No temperature data available.";
                            lbl_err.Visible = true;
                        }

                        // Optional: Handle Weather array
                        if (weatherData.Weather != null && weatherData.Weather.Length > 0)
                        {
                            string description = weatherData.Weather[0].Description;
                            lbl_err.Text = $"Description: {description}";
                            lbl_err.Visible = true;
                        }




                    }
                    else
                    {
                        lbl_err.Text = $"Error {responseMessage.StatusCode} - {responseMessage.ReasonPhrase}";
                        lbl_err.Visible = true;
                    }



                }

            }
            catch (Exception ex)
            {
            lbl_err.Text = $"Exception occured: {ex.Message}";
            lbl_err.Visible= true;
            }



        }

    }
}
