using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base (name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}~~{GetDescription()}~~{_points}~~{_isComplete}";
    }
    public override void ShowAnimation()
    {
                int i = 5;
        while (i > 0)
        {
            Console.Clear();
            Console.WriteLine("Congratulations on completing your goal!!");
            
            for (int n = i; n > 0; n--)
            {
                Console.WriteLine();
            }
            Console.WriteLine("     .-'\"'-.");
            Console.WriteLine("    / #     \\");
            Console.WriteLine("   : #       : .-'\"'-.");
            Console.WriteLine("    \\       / / #     \\");
            Console.WriteLine("     \\     / : #       :");
            Console.WriteLine("      `'q'`   \\       /");
            Console.WriteLine("        (      \\     /");
            Console.WriteLine("        )       `'q'`");
            Console.WriteLine("        (         )");
            Console.WriteLine("        )         (");
            Console.WriteLine("                  )  ");
            Console.WriteLine("                  (  ");
            Thread.Sleep(500);
            i--;
        }
    }
}