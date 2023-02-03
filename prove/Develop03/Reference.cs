

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;

        _chapter = chapter;

        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;

        _chapter = chapter;

        _verse = verse;

        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse == 0)
        {
            string display = _book + " " + _chapter.ToString() + ":" + _verse.ToString();
            return display;
        }
        else
        {
            string display = _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
            return  display;
            
        }
    }
}