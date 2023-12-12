class Program
{
    static List<Goal> goals = new List<Goal>();
    static string goalsFilePath = "goals.txt"; // File path for saving/loading goals

    static void Main()
    {
        Console.WriteLine("Welcome to Eternal Quest!");

        bool exit = false;
        do
        {
            int choice = Menu.ShowMenuAndGetChoice();

            switch (choice)
            {
                case 1:
                    Menu.CreateGoal(goals);
                    break;
                case 2:
                    RecordGoalCompletion();
                    break;
                case 3:
                    DisplayGoals();
                    break;
                case 4:
                    SaveGoals();
                    break;
                case 5:
                    LoadGoals();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (!exit);
    }

    static void RecordGoalCompletion()
    {
        Console.WriteLine("\nRecord Goal Completion:");
        DisplayGoals();

        Console.Write("Enter the index of the goal you completed: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < goals.Count)
        {
            goals[index].RecordCompletion();
        }
        else
        {
            Console.WriteLine("Invalid goal index");
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
        }

        Console.WriteLine("\nTotal Score: " + CalculateTotalScore());
    }

    static int CalculateTotalScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.Points;
        }
        return totalScore;
    }

    static void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(goalsFilePath))
            {
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.SaveGoal());
                }
            }
            Console.WriteLine("Goals saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        try
        {
            goals.Clear(); // Clear existing goals before loading
            using (StreamReader reader = new StreamReader(goalsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                        string goalType = parts[0];
                        Goal goal = CreateGoalInstance(goalType);
                        if (goal != null)
                        {
                            goal.LoadGoal(parts);
                            goals.Add(goal);
                        }
                        else
                        {
                            Console.WriteLine($"Unknown goal type: {goalType}");
                        }
                    }
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    static Goal CreateGoalInstance(string goalType)
    {
        switch (goalType)
        {
            case nameof(SimpleGoal):
                return new SimpleGoal("", "", 0);
            case nameof(EternalGoal):
                return new EternalGoal("", "", 0);
            case nameof(ChecklistGoal):
                return new ChecklistGoal("", "", 0, 0, 0);
            default:
                return null;
        }
    }
}