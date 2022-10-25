namespace PeruvianDates
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public string DateString { get; set; }
        public DateTime LocalDate { get; set; }
        public string LocalDateString { get; set; }
        public string Culture { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}