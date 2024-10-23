namespace Services;

public interface IWeatherService
{
    string GetCurrentWeather();
}

public class WeatherService : IWeatherService
{
    string[] summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    public string GetCurrentWeather()
    {
        try
        {
            return summaries[Random.Shared.Next(summaries.Length)];
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}
