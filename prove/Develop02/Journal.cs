using System.IO;

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

    public void LoadJournal(string filename, List<Entry> content)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        

        foreach (string line in lines)
        {
            Entry loadedEntry = new Entry();
            string[] parts = line.Split("^");

            loadedEntry._date = parts[0];
            
            loadedEntry._prompt = parts[1];
            
            loadedEntry._entry = parts[2];

            content.Add(loadedEntry);
        }
    }

    public void SaveJournal(string filename, List<Entry> content)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry newEntry in content)
            {
                outputFile.WriteLine(newEntry._date + "^" + newEntry._prompt + "^" + newEntry._entry);
            }
        }
    }
}