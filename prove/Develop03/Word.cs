using System.Text.RegularExpressions;

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
        string replacement = "";
        bool letterCheck;
        foreach (char character in _word)
        {
            letterCheck = Char.IsLetter(character);
            if (letterCheck == true)
            {
                replacement = replacement + "_";
            }
            else
            {
                replacement = replacement + character;
            } 
        }
        _word = replacement;
    }
}