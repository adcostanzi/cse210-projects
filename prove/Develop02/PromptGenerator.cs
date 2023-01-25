

public class PromptGenerator
{
    public List<int> _savedNumber = new List<int>();
    public PromptGenerator()
    {
    }
    public string GeneratePrompt()
    {
        List<String> listOfPrompts = new List<string>();
        using (var reader = new StreamReader("prompts.csv"))
        {
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                listOfPrompts.Add(line);
            }
        }
        
        int number;
        
        int lenghtOfList = listOfPrompts.Count;
      
        if (this._savedNumber.Count == lenghtOfList)
        {
            this._savedNumber.Clear();
        }

        do
        {
            number = GenerateRandomNumber(lenghtOfList);

        } while(this._savedNumber.Contains(number));
        

        this._savedNumber.Add(number);

        string prompt = listOfPrompts[number];

        return prompt;  
    }

    public int GenerateRandomNumber(int lenght)
    {  
        Random newNumber = new Random();
        int randomNumber = newNumber.Next(0,lenght); 
        
        return randomNumber;
    }
}