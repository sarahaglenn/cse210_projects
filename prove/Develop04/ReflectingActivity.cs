public class ReflectingActivity : Activity
{
    private List<string> _prompts = [];
    private List<string> _questions = [];
    private List<string> _promptsUsed = [];
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();
    }
    private string GetRandomPrompt(List<string>promptList)
    {
        //choose a random prompt or question from whichever list and display it
        Random num = new Random();
        string prompt = promptList[num.Next(promptList.Count())];
        return prompt;
    }
    private void DisplayPrompt()
    {  
        Console.WriteLine("Consider the following prompt: \n");

        //generate prompt unique to this session
        while (true)
        {
            string prompt = GetRandomPrompt(_prompts);

            //check if this prompt has been used this session
            if (!_promptsUsed.Contains(prompt))
            {
                Console.WriteLine($" --- {prompt} ---\n");
                Console.WriteLine("When you have something in mind, press enter to continue.");
                Console.ReadLine();
                Console.WriteLine();

                // Add this prompt to the list of used prompts
                _promptsUsed.Add(prompt);

                //if all the prompts have been used, empty the list of used prompts and begin repeating
                if (_promptsUsed.Count == _prompts.Count)
                {
                    _promptsUsed = [];
                }
                break;
            }
        }    
    }
    private void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        // Initialize a list of questions asked so far
        List<string> askedQuestions = [];
        while (DateTime.Now < endTime)
        {
            string question = GetRandomPrompt(_questions);

            //check if this question has been asked
            if (!askedQuestions.Contains(question))
            {
                Console.Write($"> {question} ");
                ShowSpinner(12);
                Console.WriteLine();
                // Add this question to list of asked questions
                askedQuestions.Add(question);

                //if all the questions have been asked, empty list of asked questions and begin repeating
                if (askedQuestions.Count == _questions.Count)
                {
                    askedQuestions = [];
                }
            }   
        }
    }
}