public class Comment
{
    private string _name;

    private string _text;


    public Comment(string name, string text)
    {
        _name = name;

        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine($"Comment: {_text}\n");
    }


}