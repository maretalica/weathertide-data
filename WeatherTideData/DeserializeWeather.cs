using System;

namespace WeatherTideStormglass
{
    internal class DeserializeWeather
    {
        public _hours[] hours { get; set; }
        public _meta meta { get; set; }
    }

    public class _hours
    {
        public _airTemperature airTemperature { get; set; }
        public DateTime time { get; set; }
    }

    public class _airTemperature
    {
        public string noaa { get; set; }
        public string sg { get; set; }
    }
}
