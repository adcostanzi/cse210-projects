
public class Database
{
    private List<Tuple<string, int, int, int, string>> _data = new List<Tuple<string, int, int, int, string>>();

    private string _book;
    private int _chapter;

    private int _initialVerse;

    private int _endVerse;

    private string _text;

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

            if (parts[3] == "")
            {
                endVerse = 0;
            }
            else
            {
                endVerse = int.Parse(parts[3]);
            }

            string text = parts[4];
            
            var scripture = new Tuple<string, int, int, int, string>(book, chapter, initialVerse, endVerse, text);

            _data.Add(scripture);   
            
        }    
    }

    public void DisplayData()
    {
        for (int i = 0; i < _data.Count; i++)
        {
            string book = _data[i].Item1;
                       
            int chapter = _data[i].Item2;
            
            int initialVerse = _data[i].Item3;

            int endVerse = _data[i].Item4;

            if (endVerse == 0)
            {
                Console.WriteLine($"{i+1}. {book} {chapter}:{initialVerse}");
            }
            else
            {
                Console.WriteLine($"{i+1}. {book} {chapter}:{initialVerse}-{endVerse}");
            }
            
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetInitialVerse()
    {
        return _initialVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public string GetText()
    {
        return _text.Replace("&",";");
    }

    public void GetScripture(string response)
    {
        int option = int.Parse(response);
        option --;
        
        _book = _data[option].Item1;
        _chapter = _data[option].Item2;
        _initialVerse = _data[option].Item3;
        _endVerse = _data[option].Item4;
        _text = _data[option].Item5;
        
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