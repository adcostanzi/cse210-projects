public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering()
    {
        Console.Write("How is the weather for the day of the event? ");
        string weather = Console.ReadLine();

        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardMessage();
        string type = GetType().ToString();
        Console.WriteLine($"Event type: {type}\nWeather forecast: {_weather}");
    }
}