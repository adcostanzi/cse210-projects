
public class Word
{
    private string _word;

    private bool _shown = true;

    public Word(string word)
    {
        _word = word;
    }

    public bool IsHidden()
    {
        if (_shown == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string GetWord()
    {
        return _word;
    }

    public void Hide()
    {
        _shown = false;
        string replacement ="";
        for (int i = 0 ; i < _word.Length ; i++)
        {
            replacement =  replacement + "_";
        }
        _word = replacement;
    }
}