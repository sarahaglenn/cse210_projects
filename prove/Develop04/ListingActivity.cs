public class ListingActivity : Activity
{
    private List<string>_listedThings = [];
    private List<string>_listingPrompts = [];
    public ListingActivity(string activityName,string activtyDescription) : base(activityName, activtyDescription)
    {
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heros?");
    }
    public void RunActivity()
    {
        StartActivity();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        string prompt = ChoosePrompt(_listingPrompts);
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
        Console.Write("> ");
        _listedThings.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_listedThings.Count} items!");

        DisplayEndMessage();
    }
    private string ChoosePrompt(List<string>promptList)
    {
        //choose a random prompt from whichever list and display it
        Random num = new Random();
        string prompt = promptList[num.Next(promptList.Count())];
        return prompt;
    }
}