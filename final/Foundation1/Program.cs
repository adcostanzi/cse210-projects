using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        int answer = 0;
        int answer2 = 0;
        string videoName;
        string videoAuthor;
        double videoLength;
        string commentAuthor;
        string commentText;

        do
        {
            Console.WriteLine("\nPlease complete the following information:");
            
            Console.Write("\nWhat is the title of the video? ");
            videoName = Console.ReadLine();
            
            Console.Write("\nWho is the author of the video? ");
            videoAuthor= Console.ReadLine();
            
            Console.Write("\nWhat is the length (in minutes) of the video? ");
            videoLength = double.Parse(Console.ReadLine());
            
            Video newVideo = new Video(videoName, videoAuthor, videoLength);
            Console.WriteLine("\nPlease add at least one comment to the video.");
            do
            {
                Console.Write("\nWho is the author of the comment? ");
                commentAuthor = Console.ReadLine();
                
                Console.Write("\nWhat does the comment say? ");
                commentText = Console.ReadLine();

                Comment newComment = new Comment(commentAuthor, commentText);
                newVideo.AddComment(newComment);

                Console.Write("\nWould you like to add another comment? (1: yes / 2: no): ");
                answer2 = int.Parse(Console.ReadLine());
            
            } while(answer2 != 2);
            
            videos.Add(newVideo);

            Console.Write("\nWould you like to add another video? (1: yes / 2: no): ");
            answer = int.Parse(Console.ReadLine());

        } while (answer != 2);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            video.DisplayComments();
        }
        
    }
}