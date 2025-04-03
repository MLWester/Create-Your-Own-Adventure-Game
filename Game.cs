public class Game
{
    private Die? die;
    //private Dragon dragon;

    public void StartGame()
    {
        die = new Die();
        //dragon = new Dragon();

        Console.WriteLine("Welcome to Choose Your Adventure Game");
        Console.WriteLine("Choose: 1. Create Character or 2. Exit. Type '1' or '2'");

        string input = Console.ReadLine()!;

        if (input == "2")
        {
            Console.WriteLine("Exiting game...");
            return;
        }

        Console.WriteLine("Character creation starting...");
    }
}