using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Manual Unit Test Runner ===\n");

        // Run character unit tests
        CharacterTest.RunPlayerUnitTest();
        Console.WriteLine("=== End of Character Unit Tests ===\n");

        // Run weapon unit tests
        WeaponTest.RunWeaponUnitTests();

        // Run Die tests
        DieTest tester = new DieTest();
        tester.RunAllTests();

        // Run dragon tests
        DragonTests dragonTests = new DragonTests();
        dragonTests.RunAllTests();

        // Run game tests
        GameTest gameTest = new GameTest();
        gameTest.RunAllTests();

        // Run messages system tests
        MessagesTests msgTests = new MessagesTests();
        msgTests.RunAllTests();

        // Example use of Die class and roll method
        Die die = new Die();
        int rollResult = die.Roll(20);
        Console.WriteLine($"You rolled a dice value of {rollResult}");

        // Start the actual game
        Console.WriteLine("\n=== Game Start ===\n");
        Messages messages = new Messages();
        messages.ReadDictionary("English"); // Change to "French" or "Spanish" to test

        Game game = new Game(messages);
        game.StartGame();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
