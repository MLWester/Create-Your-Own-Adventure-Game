public class Game
{
    private Die? die;
    //private Dragon dragon;

    public void StartGame()
    {
        die = new Die();
        //dragon = new Dragon();

        Console.WriteLine("Welcome to Choose Your Adventure Game");

        string input;

        // Loop until valid input is received
        while (true)
        {
            Console.WriteLine("Choose: 1. Create Character or 2. Exit. Type '1' or '2'");
            input = Console.ReadLine()!;

            if (input == "1" || input == "2")
            {
                break; // valid input, exit loop
            }

            Console.WriteLine("Invalid input. Please enter '1' or '2'.");
        }

        if (input == "2")
        {
            Console.WriteLine("Exiting game...");
            return;
        }

        Console.WriteLine("Character creation starting...");
    }
}
