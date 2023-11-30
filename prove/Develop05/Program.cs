
class Program
{
    static void Main(string[] args)
    {
        bool bool_is_true = true;

        Menu menu = new Menu();
        while (bool_is_true) {
        string choice = menu.Display();
        bool bool_is_true_2 = true;
        switch (choice) {
            case "1":
                while (bool_is_true_2) {
                string choice2 = menu.displayGoals();
                switch (choice2){
                    case "1":
                        Simple simple = new Simple();
                        simple.Name();
                        simple.Description();
                        simple.Point();
                        Console.WriteLine(simple.GoalList());
                        bool_is_true_2 = false;
                        break;
                    case "2":
                        Eternal eternal = new Eternal();
                        eternal.Name();
                        eternal.Description();
                        eternal.Point();
                        Console.WriteLine("Choice 2");
                        bool_is_true_2 = false;
                        break;
                    case "3":
                        CheckList checklist = new CheckList();
                        checklist.Name();
                        checklist.Description();
                        checklist.Point();
                        bool_is_true_2 = false;
                        break;
                    case "4":
                        Console.WriteLine("Back");
                        bool_is_true_2 = false;
                        Thread.Sleep(500);
                        break;
                    }
                }
                break;
            case "2":
                Console.WriteLine("choice 2");
                break;
            case "3":
                Console.WriteLine("choice 3");
                break;
            case "4":
                Console.WriteLine("choice 4");
                break;
            case "5":
                Console.WriteLine("choice 5");
                break;
            case "6":
                Console.WriteLine("GoodBye");
                Thread.Sleep(500);
                bool_is_true = false;
                break;
            }
        }
    }
}