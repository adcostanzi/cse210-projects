public class Reception : Event
{
    private string _email;



    public Reception()
    {
        Console.Write("What is the email for RSVP? ");
        string email = Console.ReadLine();
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardMessage();
        string type = GetType().ToString();
        Console.WriteLine($"Event type: {type}\nRSVP Email: {_email}");
    }
}