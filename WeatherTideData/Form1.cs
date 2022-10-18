using System;
using System.Windows.Forms;

namespace WeatherTideStormglass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TideChart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequestData web = new WebRequestData();

            DeserializeTide tide = web._tide;
            DeserializeWeather weather = web._weather;

            int offset = 3;

            foreach (var data in tide.data)
            {
                TideChart.Series["Height"].Points.AddXY(data.time.Day, data.height);
            }

            foreach (var data in weather.hours)
            {
                WeatherChart.Series["Temp"].Points.AddXY(data.time.Day, data.airTemperature.noaa);
            }

            WeatherChart.ChartAreas[0].AxisY.Minimum = (float)Math.Round((web.WeatherMinMax(weather)[0] - offset) * 100f) / 100;
            WeatherChart.ChartAreas[0].AxisY.Maximum = (float)Math.Round((web.WeatherMinMax(weather)[1] + offset) * 100f) / 100;

            label2.Text = tide.meta.station.name;
            label3.Text = "Latitude : " + tide.meta.station.lat;
            label4.Text = "Longtitude : " + tide.meta.station.lng;
            label5.Text = tide.meta.start + " - " + tide.meta.end;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
