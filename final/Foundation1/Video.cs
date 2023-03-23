public class Video
{
    private string _title;

    private string _author;

    private double _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        Console.WriteLine("\nComment added!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in minutes): {_length} minutes");
    }

    public void DisplayComments()
    {
        int numberOfComments = _comments.Count;
        Console.WriteLine($"There are {numberOfComments} comments in this video.");
        Console.WriteLine("\nComments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }


}