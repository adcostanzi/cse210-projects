

public class PromptGenerator
{
    
    public PromptGenerator()
    {
    }
    public string GeneratePrompt()
    {
        List<String> listOfPrompts = new List<string>()
         {"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"    
        };
        int lenghtOfList = listOfPrompts.Count;
        string prompt;
        
        int number = GenerateRandomNumber(lenghtOfList-1);

        prompt = listOfPrompts[number];

        return prompt;  
    }

    public int GenerateRandomNumber(int lenght)
    {
       
        
        Random newNumber = new Random();
        int randomNumber = newNumber.Next(0,lenght); 
       
        return randomNumber;
    }
}