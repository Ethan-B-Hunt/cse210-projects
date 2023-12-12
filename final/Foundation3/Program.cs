
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        // Create instances of each type of event
        Lecture lectureEvent = new Lecture("C# Workshop", "Learn C# programming", "2023-12-15", "14:00",
            new Address("123 Main St", "Cityville", "State", "12345"), "Jane Doe", 50);

        Reception receptionEvent = new Reception("Networking Mixer", "Connect with professionals", "2023-12-20", "18:30",
            new Address("456 Oak St", "Townsville", "State", "67890"), "rsvp@example.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Enjoy food and games", "2023-12-25", "12:00",
            new Address("789 Pine St", "Villagetown", "State", "54321"), "Sunny with a chance of clouds");
        
        Console.WriteLine("Select an event");
        Console.WriteLine();
        Console.WriteLine("1) Lecture Event:");
        Console.WriteLine("2) Reception Event:");
        Console.WriteLine("3) Outdoor Gathering Event:");
        string userinput = Console.ReadLine();
        if (userinput == "1"){
            Console.Clear();
            Console.WriteLine("Lecture Event:");
            string eventType = ShortMenu();
            switch(eventType){
                case "1":
                    Console.WriteLine();
                    Console.WriteLine(lectureEvent.StandardDetails());
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine(lectureEvent.FullDetails());
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine(lectureEvent.ShortDescription());
                    break;
            }
        } 
        else if (userinput == "2"){
            Console.Clear();
            Console.WriteLine("Lecture Event:");
            string eventType = ShortMenu();
            switch(eventType){
                case "1":
                    Console.WriteLine();
                    Console.WriteLine(receptionEvent.StandardDetails());
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine(receptionEvent.FullDetails());
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine(receptionEvent.ShortDescription());
                    break;
            }
        } 
        else {
            Console.Clear();
            Console.WriteLine("Lecture Event:");
            string eventType = ShortMenu();
            switch(eventType){
                case "1":
                    Console.WriteLine();
                    Console.WriteLine(outdoorEvent.StandardDetails());
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine(outdoorEvent.FullDetails());
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine(outdoorEvent.ShortDescription());
                    break;
            }
        }
    }

    public static string ShortMenu(){
        Console.WriteLine("1) StandardDetails");
        Console.WriteLine("2) FullDetails");
        Console.WriteLine("3) ShortDescription");
        string userinput = Console.ReadLine();
        if (userinput == "1"){
            Console.Clear();
            Console.WriteLine("StandardDetails");
            return "1";
        } else if (userinput == "2"){
            Console.Clear();
            Console.WriteLine("FullDetailst:");
            return "2";
        } else {
            Console.Clear();
            Console.WriteLine("ShortDescription");
            return "3";
        }
    }
}
