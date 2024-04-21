using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
namespace _445AssignmentPart2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string APIkey = "e18a0dcb1aee013d8581fcdb4a429fff";
        private void citySearchButton_Click(object sender, EventArgs e)
        {
            //Had to do this since to check for any city would break the code, oh well
            bool check1 = textBoxCity.Text.Equals("Phoenix");
            bool check2 = textBoxCity.Text.Equals("Tempe");
            if (check1 == true || check2 == true)
            {
                getWeather();
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
               
        }
        void getWeather()
        {
           
            using (WebClient web = new WebClient())
            {
                //Can not check which city to pick from, stick only with default
               //used openweather api for this project, credits to them
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", textBoxCity.Text, APIkey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                
                    //This is not working as intended, the icon is not showing up, god I have no clue
                pictureBox1.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon + ".png";
                conditionLabel.Text = Info.weather[0].main;
                detailsLabel.Text = Info.weather[0].description;
                sunsetNumLabel.Text = convert(Info.sys.sunset).ToShortTimeString();
                sunriseNumLabel.Text = convert(Info.sys.sunrise).ToShortTimeString();
                windSpeedNumLabel.Text = Info.wind.speed.ToString();
                pressureNumLabel.Text = Info.main.pressure.ToString();
                tempLabel.Text = Info.main.temp.ToString() + "°F";
                
            }
        }

        DateTime convert(long milli)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(milli).ToLocalTime();
            return day;
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
