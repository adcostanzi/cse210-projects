
public class Database
{
    private List<Scripture> _data = new List<Scripture>();

    public Database()
    {

    }

    public void LoadData()
    {
        string[] lines = System.IO.File.ReadAllLines("scriptures.csv");
        
        foreach (string line in lines)
        {
                     
            string[] parts = line.Split(";");
            
            string book = parts[0];
                       
            int chapter = int.Parse(parts[1]);
            
            int initialVerse = int.Parse(parts[2]);

            int endVerse;

            string text = parts[4].Replace("&",";");


            if (parts[3] == "")
            {
                endVerse = 0;
                Reference newReference = new Reference(book,chapter,initialVerse);
                Scripture newScripture = new Scripture(newReference, text);
                _data.Add(newScripture);   
            }
            else
            {
                endVerse = int.Parse(parts[3]);
                Reference newReference = new Reference(book,chapter,initialVerse,endVerse);
                Scripture newScripture = new Scripture(newReference, text); 
                _data.Add(newScripture);   
            }  
        }    
    }

    public void DisplayData()
    {
        for (int i = 0; i < _data.Count; i++)
        {
            string reference = _data[i].DisplayReferenceOnly();
            Console.Write($"{i+1}. {reference}");
            Console.Write("\n");
            
        }
    }


    public Scripture GetScripture(string response)
    {
        
        int option = int.Parse(response);
        option --;
        
        return _data[option];
    }

    public bool IsOptionViable(string option)
    {
        bool isViable;
        int choice = int.Parse(option);
        int limit = _data.Count;
        if (choice>0 && choice<= limit)
        {
            isViable = true;
        }
        else
        {
            isViable = false;
        }
        return isViable;
    }
}