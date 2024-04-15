using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8_Rodin_
{
    internal class Cloudy : Weather
    {
        public string clouds = "облачно";
        public int chanceOfrain;
        public Cloudy(string location, DateTime date, int temperature,int chn) : base(location, date, temperature)
        {
            chanceOfrain = chn;
        }

        public override void DisplayWeather()
        {
            MessageBox.Show($"Погода в {Location} на {Date}: Температура {Temperature}°C, Состояние : {clouds}");
        }

        public void CloudinessLevel()
        {
            MessageBox.Show($"Шанс дождя: {chanceOfrain}.");
        }

        public override void WeatherDescription()
        {
            MessageBox.Show("Погодные условия: средняя облачность");
        }
    }
}
