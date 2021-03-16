using System;
namespace WeatherLogger.Data
{
    public class Measure
    {
        public Guid Id { get; set; }
        public DateTime MeasuredAt { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal WindSpeed { get; set; }
        public decimal WindDirection { get; set; }
    }
}
