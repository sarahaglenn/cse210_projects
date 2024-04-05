using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = [];
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    private int CountComments()
    {
        int length = _comments.Count;
        return length;
    }
    public string GetFullDetailString()
    {
        return GetVideoString() + GetCommentsString();
    }
    private string GetVideoString()
    {
        double minutes = Math.Floor(_length / 60);
        double remainingSeconds = _length % 60;
        string videoDetails;
        if (remainingSeconds > 9)
        {
            videoDetails = $"Title: {_title}\nAuthor: {_author}\nLength: {minutes}:{remainingSeconds}\nNumber of Comments: {CountComments()}\n";
        }
        else
        {
            videoDetails = $"Title: {_title}\nAuthor: {_author}\nLength: {minutes}:0{remainingSeconds}\nNumber of Comments: {CountComments()}\n";
        }
        return videoDetails;
    }
    private string GetCommentsString()
    {
        string allComments = "";
        foreach (Comment c in _comments)
        {
            allComments += c.GetDetailString() + "\n";
        }
        return allComments;
    }
}