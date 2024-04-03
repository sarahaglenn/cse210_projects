using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
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
        string videoDetails = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {CountComments()}\n";
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