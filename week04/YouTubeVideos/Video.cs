public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
        _comments = new List<Comment>();
    }

    public int CommentsNum()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title:{_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLength} sec");
        Console.WriteLine($"{CommentsNum()} comments:");

        Console.WriteLine("-------------------------");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine("-------------------------");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}