class WeatherForecast
{
    private WeatherData weatherData;

    public WeatherForecast(string City, double Temperature, double Humidity, double WindSpeed)
    {
        weatherData = SetWeather(City, Temperature, Humidity, WindSpeed);
    }

    public WeatherData SetWeather(string City, double Temperature, double Humidity, double WindSpeed)
    {
        var weather = new WeatherData(City, Temperature, Humidity, WindSpeed);
        return weather;
    }

    public string AutoDescription()
    {
        if (weatherData.Temperature >= 30 && weatherData.WindSpeed < 10)
        {
            return "Hot and Calm";
        }
        else if (weatherData.Temperature >= 20 && weatherData.WindSpeed >= 10)
        {
            return "Hot and Windy";
        }
        else if (weatherData.Temperature >= 10 && weatherData.WindSpeed < 10)
        {
            return "Pleasant and Calm";
        }
        else if (weatherData.Temperature <= 0)
        {
            return "Snowy and Rainy";
        }
        else
        {
            return "";
        }
    }

    public void GetWeatherForecast()
    {
        weatherData.WeatherDescription = AutoDescription();
        System.Console.WriteLine(weatherData.City + " " + weatherData.WeatherDescription + " " + weatherData.Date);
    }
}