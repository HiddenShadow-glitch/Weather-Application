using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        string cs = "Data Source=DESKTOP-DPVB2PS\\SQLEXPRESS04;Initial Catalog=WeatherDB;Integrated Security=True";
        string APIKey = "20055a33aee75b862b371306f55e058f";

        public Form1()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
            saveToDatabase(TBCity.Text, Info.main.temp, Info.weather[0].main);
        }

        double lon;
        double lat;
        WeatherInfo.root Info;

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string apiKey = config.ApiKey;
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                // Use http:// to avoid SSL issues
                string iconUrl = "http://openweathermap.org/img/wn/" + Info.weather[0].icon + "@2x.png";
                byte[] imgData = web.DownloadData(iconUrl);
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    picIcon.Image = Image.FromStream(ms);
                }

                lblCon.Text = Info.weather[0].main;
                lblDetails.Text = Info.weather[0].description;
                lblSSna.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                lblSRna.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                lblWSna.Text = Info.wind.speed.ToString();
                lblPna.Text = Info.main.pressure.ToString();
                lblTna.Text = Info.main.temp.ToString();

                lon = Info.coord.lon;
                lat= Info.coord.lat;
            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format(
                    "http://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&cnt=40&appid={2}&units=metric",lat, lon, "20055a33aee75b862b371306f55e058f"
                );

                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                var dailyList = ForecastInfo.list
                .GroupBy(x => convertDateTime(x.dt).Date)
                .Select(g => g.First())
                .Take(7)
                .ToList();

                FLP.Controls.Clear();

                for (int i = 0; i < dailyList.Count; i++)
                {
                    ForecastUC FUC = new ForecastUC();

                    string iconUrl = "http://openweathermap.org/img/wn/"
                        + dailyList[i].weather[0].icon + "@2x.png";

                    byte[] imgData = web.DownloadData(iconUrl);
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        FUC.picWIcon.Image = System.Drawing.Image.FromStream(ms);
                    }

                    FUC.labMainW.Text = dailyList[i].weather[0].main;
                    FUC.labWDes.Text = dailyList[i].weather[0].description;
                    FUC.labDT.Text = convertDateTime(dailyList[i].dt).DayOfWeek.ToString();

                    FLP.Controls.Add(FUC);
                }
            }
        }

        void saveToDatabase(string city, double temperature, string condition)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "INSERT INTO WeatherSearchHistory (City, Temperature, Condition) VALUES (@city, @temp, @condition)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@temp", temperature);
                cmd.Parameters.AddWithValue("@condition", condition);
                cmd.ExecuteNonQuery();
            }
        }
    }
}