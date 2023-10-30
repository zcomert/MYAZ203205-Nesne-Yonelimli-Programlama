class WeatherData
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public string City { get; set; }
    public double WindSpeed { get; set; }
    public DateTime Date { get; private set; }
    public string WeatherDescription { get; set; }
    public WeatherData()
    {
        Date = DateTime.Now;
    }

    public WeatherData(string City, double temperature, double humidity, double windSpeed)
    : this()
    {
        this.City = City;
        Temperature = temperature;
        Humidity = humidity;
        WindSpeed = windSpeed;
    }
}