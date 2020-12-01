using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather
{
    class WeatherResponse
    {
        public string Name { set; get; }
        public MainInfo Main { set; get; }
    }
    class MainInfo
    {
        public float temp { get; set; }
    }
}
