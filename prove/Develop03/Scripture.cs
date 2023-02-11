

public class Scripture
{
    private Reference _reference;

    private List<Word> _renderedText = new List<Word>();

    private List<int> _hiddenPositions = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] textToRender = text.Split(" ");

        foreach (string part in textToRender)
        {
            Word newWord = new Word(part);

            _renderedText.Add(newWord);

        }
        
    }

   
    public void DisplayScripture()
    {   
        string reference = _reference.GetReference();
        string text = "";
        List<String> listOfWords = new List<String>();
        
        Console.WriteLine("\n" + reference);
        
        foreach (Word palabra in _renderedText)
        {
            string word = palabra.GetWord();
            listOfWords.Add(word);
        }
        string[] words = listOfWords.ToArray();
        text = string.Join(" ", words);
        Console.WriteLine(text + "\n");
    }

    public string DisplayReferenceOnly()
    {
        string reference = _reference.GetReference();
        return reference;
    }

    public void HideWords()
    {

       int randomNumber;

       for (int i = 0; i < 4; i++)
       {
            

            do
            {
                randomNumber = GetRandomNumber();

            } while (_hiddenPositions.Contains(randomNumber));
    
    
            _hiddenPositions.Add(randomNumber);

            foreach (int number in _hiddenPositions)
            {
                _renderedText[number].Hide();
            }

            if (_renderedText.Count == _hiddenPositions.Count)
            {
                i = 4;
            }
            
        
       }        

    }

    public bool IsScriptureHidden()
    {
        bool isComplete = false;
        int counter = 0;

        foreach (Word word in _renderedText)
        {
            bool condition = word.IsHidden();
            if (condition == true)
            {
                counter ++;
            }
        }

        if (_renderedText.Count == counter)
        {
            isComplete = true;
        }

        return isComplete;
    }

    private int GetRandomNumber()
    {
        Random random = new Random();

        int number = random.Next(0, _renderedText.Count);

        return number;
    }
}