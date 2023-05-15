using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWinFormsApp.OpenWeather
{
    internal class Wind
    {
        private double speed;

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }
}
