using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = [];
    public ListingActivity(string name,string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heros?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        string prompt = ChoosePrompt(_prompts);
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        GetListFromUser();

        DisplayEndingMessage();
    }
    private string ChoosePrompt(List<string>promptList)
    {
        //choose a random prompt from whichever list and display it
        Random num = new Random();
        string prompt = promptList[num.Next(promptList.Count())];
        return prompt;
    }
    private List<string> GetListFromUser()
    {
        List<string> listedThings = [];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            listedThings.Add(Console.ReadLine());
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        return listedThings;
    }
}