using System;

namespace WeatherTideStormglass
{
    internal class DeserializeTide
    {
        public _data[] data { get; set; }
        public _meta meta { get; set; }
    }
    public class _data
    {
        public string height { get; set; }
        public DateTime time { get; set; }
        public string type { get; set; }
    }

    public class _meta
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public _station station { get; set; }
    }
    public class _station
    {
        public string lat { get; set; }
        public string lng { get; set; }
        public string name { get; set; }
        public string source { get; set; }
    }
}
