public class Menu
{
    public static int ShowMenuAndGetChoice()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Goal Completion");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Exit");

        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }

        return -1;
    }

    public static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("\nCreate Goal:");

        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string goalDescription = Console.ReadLine();

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int goalType = GetChoice();

        switch (goalType)
        {
            case 1:
                CreateSimpleGoal(goals, goalName, goalDescription);
                break;
            case 2:
                CreateEternalGoal(goals, goalName, goalDescription);
                break;
            case 3:
                CreateChecklistGoal(goals, goalName, goalDescription);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private static int GetChoice()
    {
        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }

        return -1;
    }

    private static void CreateSimpleGoal(List<Goal> goals, string name, string description)
    {
        Console.Write("Enter the points for completing the goal: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            goals.Add(new SimpleGoal(name, description, points));
            Console.WriteLine($"Simple Goal '{name}' created!");
        }
        else
        {
            Console.WriteLine("Invalid points value. Goal creation failed.");
        }
    }

    private static void CreateEternalGoal(List<Goal> goals, string name, string description)
    {
        Console.Write("Enter the points for each completion of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int pointsPerCompletion))
        {
            goals.Add(new EternalGoal(name, description, pointsPerCompletion));
            Console.WriteLine($"Eternal Goal '{name}' created!");
        }
        else
        {
            Console.WriteLine("Invalid points value. Goal creation failed.");
        }
    }

    private static void CreateChecklistGoal(List<Goal> goals, string name, string description)
    {
        Console.Write("Enter the points for each completion of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int pointsPerCompletion))
        {
            Console.Write("Enter the target number of completions for the bonus: ");
            if (int.TryParse(Console.ReadLine(), out int targetCompletions))
            {
                Console.Write("Enter the bonus points for achieving the target completions: ");
                if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    goals.Add(new ChecklistGoal(name, description, pointsPerCompletion, targetCompletions, bonusPoints));
                    Console.WriteLine($"Checklist Goal '{name}' created!");
                }
                else
                {
                    Console.WriteLine("Invalid bonus points value. Goal creation failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid target completions value. Goal creation failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid points value. Goal creation failed.");
        }
    }
}