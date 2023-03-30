public class Lecture : Event
{
    private string _speaker;

    private int _capacity;


    public Lecture()
    {
        Console.Write("Who is the speaker at the lecture? ");
        string speaker = Console.ReadLine();

        Console.Write("What is the capacity for the event? ");
        int capacity = int.Parse(Console.ReadLine());

        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardMessage();
        string type = GetType().ToString();
        Console.WriteLine($"Event type: {type}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}