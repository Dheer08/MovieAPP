using System;

namespace MovieAPP
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        //hell this shakthi branch

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        //testing sample
        //Weatherforecasting.......
        //manideeep changed
    }
}
