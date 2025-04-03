public class Game
{
    private Die? die;
    // I have commented out classes until they are implemented
    //private Dragon? dragon;
    //private Messages? messages;
    //private Player? player;

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
        //messages = new Messages();
        //messages.SetCurrentLanguage("English");
        //messages.ReadDictionary("english.txt");

        //Console.WriteLine(messages.GetMessage(1)); // welcome
        //Console.WriteLine(messages.GetMessage(2)); // menu

        //Console.WriteLine(messages.GetMessage(3)); // "What is your name?"
        //string name = Console.ReadLine()!;

        //Console.WriteLine(messages.GetMessage(4)); // "Choose your race:"
        //string race = Console.ReadLine()!;

        //Console.WriteLine(messages.GetMessage(5)); // "Choose your occupation:"
        //string occupation = Console.ReadLine()!;

        // Create player
        //player = new Player(name, race, occupation);

        //Console.WriteLine("Character successfully created!");
        //Console.WriteLine(player.DisplayStats());

        // Continue to combat
        //Combat combat = new Combat(player, dragon);
        //combat.PlayerAttacksDragonSequence();
        //combat.DragonAttacksPlayerSequence();

        // End game
        //EndGame();
    }
}
