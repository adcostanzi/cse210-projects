using System.IO;
using Microsoft.VisualBasic.FileIO;

public class Journal
{
    public List<Entry> _content = new List<Entry>();
    public PromptGenerator _newPrompt = new PromptGenerator();

    public Journal()
    {}
    public Entry AddEntry()
    {
        
        Entry userEntry = new Entry();
        DateTime today = DateTime.Now;
      
        userEntry._date = today.ToShortDateString();
        userEntry._prompt = this._newPrompt.GeneratePrompt();
        Console.WriteLine(userEntry._prompt);
        Console.Write("Your entry: ");
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
            
            string[] parts = line.Split(";");

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
                outputFile.WriteLine(newEntry._date + ";" + newEntry._prompt + ";" +newEntry._entry);
            }
        }
    }
}