

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public Entry()
    {}
    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Your entry: {_entry}");
    }
}