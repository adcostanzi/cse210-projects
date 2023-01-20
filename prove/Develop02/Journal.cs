

public class Journal
{
    public List<Entry> _content = new List<Entry>();
    public List<int> _controlList = new List<int>();

    public Journal()
    {}
    public Entry AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        Entry userEntry = new Entry();
        DateTime today = DateTime.Now;
      
        userEntry._date = today.ToShortDateString();
        userEntry._prompt = newPrompt.GeneratePrompt();
        Console.WriteLine(userEntry._prompt);
        userEntry._entry = Console.ReadLine();      
        return userEntry;

    }
    public void DisplayJournal()
    {
        foreach (Entry item in _content)
        {
            item.DisplayEntry();
        }
    }
}