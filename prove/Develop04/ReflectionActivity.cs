public class ReflectionActivity : Activity
{
    private List<string> _eventPrompts = [];
    private List<string> _questionPrompts = [];
    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        _eventPrompts.Add("Think of a time when you stood up for someone else");
        _eventPrompts.Add("Think of a time when you did something really difficult.");
        _eventPrompts.Add("Think of a time when you helped someone in need");
        _eventPrompts.Add("Think of a time when you did something truly selfless");

        _questionPrompts.Add("Why was this experience meaningful to you?");
        _questionPrompts.Add("Have you ever done anything like this before?");
        _questionPrompts.Add("How did you get started?");
        _questionPrompts.Add("How did you feel when it was complete?");
        _questionPrompts.Add("What made this time different than other times when you were not as successful?");
        _questionPrompts.Add("What is your favorite thing about this experience?");
        _questionPrompts.Add("What could you learn from this experience that applies to other situations?");
        _questionPrompts.Add("What did you learn about yourself through this experience?");
        _questionPrompts.Add("How can you keep this experience in mind in the future?");
    }
    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt: \n");
        string prompt = ChoosePrompt(_eventPrompts);
        Console.WriteLine($" --- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            //find a way not to repeat questions
            string question = ChoosePrompt(_questionPrompts);
            Console.Write($"> {question} ");
            ShowSpinner(8);
            Console.WriteLine();
        }
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