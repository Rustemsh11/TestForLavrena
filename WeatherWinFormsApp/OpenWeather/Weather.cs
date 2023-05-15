using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWinFormsApp.OpenWeather
{
    internal class Weather
    {

        private string description;
        public string Description 
        { 
            get
            {
                return description;
            }
            set
            {
                description = value ;
            }
        }
    }
}
