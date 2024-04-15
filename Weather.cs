using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8_Rodin_
{
    internal class Weather
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }

        public Weather(string location, DateTime date, int temperature)
        {
            Location = location;
            Date = date;
            Temperature = temperature;
        }

        public virtual void DisplayWeather()
        {
            MessageBox.Show($"Погода в {Location} на {Date}: Температура {Temperature}°C");
        }

        public virtual void WeatherDescription()
        {
            MessageBox.Show("Погодные условия: нейтрально.");
        }

        public string SetLocation(string loc)
        {
            Location = loc;
            return Location;
        }

        public int SetTemp(int temp)
        {
            Temperature = temp;
            return Temperature;
        }
    }
}
