public abstract class Activity
{
    protected string _name;
    private string _date;
    protected int _length;

    public Activity()
    {

        Console.Write("What is the date (dd-mm-yyyy)? ");
        string date = Console.ReadLine();

        Console.Write("What was the length of the activity (in minutes)? ");
        int length = int.Parse(Console.ReadLine());

        _date = date;
        _length = length;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        string type = GetType().ToString();
        string summary = $"{_date} {type} ({_length} min): Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }
   
}