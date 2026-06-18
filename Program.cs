using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Game game = new Game();
        Console.WriteLine("Welcome to the Number Guessing Game!\n" +
           "I'm thinking of a number between 1 and 100.\n" +
           "You have 5 chances to guess the correct number.\n");

        string exit = "";

        do
        {
            Lvl(out int chances);
            Game(chances);

        } while(Exit());
    }

    private static bool Exit(){
        while (true)
        {
            Console.WriteLine("Do you want to continue? y/n");

            string command = Console.ReadLine() ?? "";

            switch (command.Trim().ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.WriteLine("Wrong command");
                break;
            }
        }
    }

    public static void Game(int chances)
    {

        Console.WriteLine("Let's start the game!\n");

        Random rand = new Random();

        int val = rand.Next(1, 100);


        for (int i = 0; i < chances; i++)
        {
            Console.Write("Enter your guess: ");

            Int32.TryParse(Console.ReadLine(), out int guess);

            if (Check(guess, val))
            {
                Console.WriteLine($"Congratulations! You guessed the correct number in {++i} attempts.");
                return;
            }
            else if (i == chances - 1) {
                Console.WriteLine("Loser!");
            }
        }
    }

    private static bool Check(int guess, int val)
    {
        if (guess > val)
        {
            Console.WriteLine($"Incorrect! The number is less than {guess}.");
            return false;
        }
        else if (guess == val) { 
            return true;
        }
        else
        {
            Console.WriteLine($"Incorrect! The number is greater than {guess}.");
            return false;
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