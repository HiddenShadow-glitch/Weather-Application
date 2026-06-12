using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Application
{
    class WeatherForecast
    {
        public class main //temperature
        {
            public double temp {  get; set; }
        }

        public class weather 
        {
            public string main {  get; set; }
            public string description {  get; set; }
            public string icon {  get; set; }
        }


        public class list //daily
        {
            public long dt { get; set; }
            public main main { get; set; }
            public List<weather> weather {  get; set; }
        }

        public class ForecastInfo
        {
            public List<list> list { get; set; }

        }


    }
}
