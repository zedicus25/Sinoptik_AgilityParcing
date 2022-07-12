using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.Model
{
    internal class HourTemperature
    {
        public string Hours { get; set; }
        public string Icon { get; set; }
        public string MainTemperature { get; set; }
        public string SensTemperature { get; set; }
        public int Pressure { get; set; }
        public int Wetness { get; set; }
        public float Wind { get; set; }
        public int Precipitation { get; set; }
        public HourTemperature(string hours, string icon, string mainTemp, string sensTemp, int press, float wind)
        {
            Hours = hours;
            Icon = icon;
            MainTemperature = mainTemp;
            SensTemperature = sensTemp;
            Pressure = press;
            Wind = wind;
        }
    }
}
