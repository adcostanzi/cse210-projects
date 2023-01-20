

public class Journal
{
    public List<Entry> _content = new List<Entry>();

    public Journal()
    {}
    public Entry AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        Entry userEntry = new Entry();
        DateTime today = DateTime.Now;
      
        userEntry._date = today.ToLongDateString();
        userEntry._prompt = newPrompt.GeneratePrompt();
        Console.WriteLine(userEntry._prompt);
        userEntry._entry = Console.ReadLine();      
        return userEntry;

    }
}