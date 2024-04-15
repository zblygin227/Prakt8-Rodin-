using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8_Rodin_
{
    internal class Hurricane : Weather
    {
        public string hurricane = "ураган";
        public DateTime dateOffStorm;
        public Hurricane(string location, DateTime date, int temperature, DateTime dateoff) : base(location, date, temperature)
        {
            dateOffStorm = dateoff;
        }

        public override void DisplayWeather()
        {
            MessageBox.Show($"Погода в {Location} на {Date}: Температура {Temperature}°C, Состояние : {hurricane}");
        }

        public void StormDate()
        {
            MessageBox.Show($"Конец урагана: {dateOffStorm}");
        }

        public override void WeatherDescription()
        {
            MessageBox.Show("Погодные условия: ураган");
        }
    }
}
