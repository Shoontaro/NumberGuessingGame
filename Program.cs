using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!\n" +
            "I'm thinking of a number between 1 and 100.\n" +
            "You have 5 chances to guess the correct number.\n");
        
            Lvl(out int chanses);
            Game(chanses);
        
    }

    public static void Game(int chanses) 
    {
        Console.WriteLine("Let's start the game!\n");

        Random rand = new Random();
        

        for (int i = 0; i < chanses; i++)
        {
            Console.Write("Enter your guess: ");

        }
    }

    public static void Lvl(out int chanses)
    {
        Console.WriteLine("Please select the difficulty level:\n" +
               "1. Easy (10 chances)\r\n2. Medium (5 chances)\r\n3. Hard (3 chances)");

        int lvl;
       
        do
        {
            Console.Write("Enter your choice: ");

            string comm = Console.ReadLine()??"";

            Int32.TryParse(comm, out lvl);

        } while(lvl<1||lvl>3);

        switch (lvl) {
        case 1:
                Console.WriteLine("\nGreat! You have selected the Easy difficulty level.");
                chanses = 10;
                break;
        case 2:
                Console.WriteLine("\nGreat! You have selected the Medium difficulty level.");
                chanses = 5;
                break;
        case 3:
                Console.WriteLine("\nGreat! You have selected the Hard difficulty level.");
                chanses = 3;
                break;
        default: chanses = 10;
                break;
        }
    }
}