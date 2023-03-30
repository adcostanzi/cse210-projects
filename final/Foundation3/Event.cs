public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event()
    {
        Console.Write("What is the title of the Event? ");
        string title = Console.ReadLine();

        Console.Write("What is the description of the Event? ");
        string description = Console.ReadLine();

        Console.Write("What year will the event be held? ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("During what month will the event be held (Write month in numbers, i.e. March = 03 or 3)? ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("What day will the event be held? ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("What time will the event be held (i.e. 7:30pm)? ");
        string time = Console.ReadLine();

        DateTime date = new DateTime(year, month, day);

        Address address = new Address();

        _title = title;

        _description = description;

        _date = date.ToShortDateString();

        _time = time;

        _address = address;
        
    }

    public string GetTitle()
    {
        return _title;
    }
    public void DisplayStandardMessage()
    {
        string address = _address.GetAddress();
        Console.WriteLine($"\nEvent: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{address}");
    }

    public abstract void DisplayFullDetails();
    
    public void DisplayShortDescription()
    {
        string type = GetType().ToString();

        Console.WriteLine($"\nEvent type: {type}\nTitle: {_title}\nDate and time: {_date}");


    }
}