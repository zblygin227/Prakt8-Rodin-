using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prakt8_Rodin_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Weather wet;
        Sunny sun ;
        Hurricane huc;
        Cloudy clod;

        //Родительский класс
        private void WeatherCreate_Clicked(object sender, RoutedEventArgs e)
        {
            if (location.Text == "" || temp.Text == "" || datePic.SelectedDate.Value.Year < 2000)
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                string loced = location.Text;
                Int32.TryParse(temp.Text, out int tmp);
                var date = datePic.SelectedDate;
                DateTime dt = (DateTime)date;
                wet = new Weather(loced, dt, tmp);
                MessageBox.Show("Погода записана");
            }
        }

        private void WeatherEdit_Clicked(object sender, RoutedEventArgs e)
        {
            if (locationNew.Text != "" || tempNew.Text != "")
            {
                if (locationNew.Text != "") wet.SetLocation(locationNew.Text);
                if (tempNew.Text != "") wet.SetTemp(Int32.Parse(tempNew.Text));
                MessageBox.Show("Данные погоды изменены");
            }
            else
            {
                MessageBox.Show("Введите новые данные погоды");
            }
        }

        private void ShowWeather_Clicled(object sender, RoutedEventArgs e)
        {
            wet.DisplayWeather();
        }





        //Класс Sunny(дочерний от Weather)
        private void SunnyCreate_Clicked(object sender, RoutedEventArgs e)
        {
            if (sunnyLoced.Text == "" || sunnyTemp.Text == "" || sunnyDatepic.SelectedDate.Value.Year < 2000 || UFlvl.Text == "")
            {
                MessageBox.Show("Укажите данные");
            }
            else
            {
                string str = sunnyLoced.Text;
                Int32.TryParse(sunnyTemp.Text, out int temp);
                var date = sunnyDatepic.SelectedDate;
                DateTime dt = (DateTime)date;
                int uf = Int32.Parse(UFlvl.Text);
                sun = new Sunny(str, dt, temp, uf);
                MessageBox.Show("Солнечная погода записана");
            }
        }

        private void UFlvlKnow_Clicked(object sender, RoutedEventArgs e)
        {
            if (sun != null)
            {
                sun.SunnyLevel();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }

        private void SunnyDisplay_Clicked(object sender, RoutedEventArgs e)
        {
            if (sun == null)
            {
                MessageBox.Show("Прогноза нет");
            }
            else
            {
                sun.WeatherDescription();
            }
        }

        private void SunnyShow_Clicked(object sender, RoutedEventArgs e)
        {
            if (sun == null)
            {
                MessageBox.Show("Прогноза нет");
            }
            else
            {
                sun.DisplayWeather();
            }           
        }





        //Класс Cloudy(дочерний от Weather)
        private void cloudyCreate_Clicked(object sender, RoutedEventArgs e)
        {
            if (cloudyLoced.Text == "" || cloudyTemp.Text == "" || cloudyDatepic.SelectedDate.Value.Year < 2000 || cloudyChanceRain.Text == "")
            {
                MessageBox.Show("Укажите данные");
            }
            else
            {
                int chns = Int32.Parse(cloudyChanceRain.Text);
                string str = cloudyLoced.Text;
                int tmp = Int32.Parse(cloudyTemp.Text);
                var date = cloudyDatepic.SelectedDate;
                DateTime dt = (DateTime)date;
                clod = new Cloudy(str,dt,tmp,chns);
                MessageBox.Show("Облачная погода записана");
            }
        }

        private void ChanceOfRainKnow_Clicked(object sender, RoutedEventArgs e)
        {
            if (clod != null)
            {
                clod.CloudinessLevel();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }

        private void CloudyDesc_Clicked(object sender, RoutedEventArgs e)
        {
            if (clod != null)
            {
                clod.WeatherDescription();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }

        private void CloudyShow_Clicked(object sender, RoutedEventArgs e)
        {
            if (clod != null)
            {
                clod.DisplayWeather();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }






        //Класс Hurricane(дочерний от Weather)
        private void StormCreate_Clicked(object sender, RoutedEventArgs e)
        {
            if (stormLoced.Text == "" || stormTemp.Text == "" || stormDate.SelectedDate.Value.Year < 2000 || stormDateOff.SelectedDate.Value.Year < stormDate.SelectedDate.Value.Year)
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                string str = stormLoced.Text;
                int tmp = Int32.Parse(stormTemp.Text);
                var date1 = stormDate.SelectedDate;
                DateTime dt1 = (DateTime)date1;
                var date2 = stormDateOff.SelectedDate;
                DateTime dt2 = (DateTime)date2;
                huc = new Hurricane(str,dt1,tmp,dt2);
                MessageBox.Show("Ураган записан");
            }        
        }

        private void StormOff_Clicked(object sender, RoutedEventArgs e)
        {
            if (huc != null)
            {
                huc.StormDate();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }

        private void StormDisplay_Clicked(object sender, RoutedEventArgs e)
        {
            if (huc != null)
            {
                huc.WeatherDescription();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }

        private void StormShow_Clicked(object sender, RoutedEventArgs e)
        {
            if (huc != null)
            {
                huc.DisplayWeather();
            }
            else
            {
                MessageBox.Show("Прогноза нет");
            }
        }
    }
}
