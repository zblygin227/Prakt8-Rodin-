using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8_Rodin_
{
    internal class Sunny : Weather
    {
        public string sunny = "солнечно";
        public int rentgen {  get; set; }
        public Sunny(string location, DateTime date, int temperature, int rent) : base(location, date, temperature)
        {
            rentgen = rent;
        }
        public override void DisplayWeather()
        {
            MessageBox.Show($"Погода в {Location} на {Date}: Температура {Temperature}°C, Состояние : {sunny}");
        }

        public void SunnyLevel()
        {
            MessageBox.Show($"УФ уровень: {rentgen}");
        }

        public override void WeatherDescription()
        {
            MessageBox.Show("Погодные условия: солнечно");
        }
    }
}
