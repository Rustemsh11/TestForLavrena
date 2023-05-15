using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using WeatherWinFormsApp.Weather;

namespace WeatherWinFormsApp.OpenWeather
{
    internal class WeatherInfo
    {
        private Weather[] weather;
        private Main main;
        private Wind wind;

        public Weather[] Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
            }
        }
        public Main Main
        {
            get
            {
                return main;
            }
            set
            {
                main = value;
            }
        }
        public Wind Wind
        {
            get
            {
                return wind;
            }
            set
            {
                wind = value;
            }
        }

    }
}
