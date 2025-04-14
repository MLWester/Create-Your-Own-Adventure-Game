using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("=== Manual Unit Test Runner ===\n");

        // 1. Run message system tests (multi-language support)
        // MessagesTests msgTests = new MessagesTests();
        // msgTests.RunAllTests();

        // 2. Run weapon unit tests
        // WeaponTest.RunWeaponUnitTests();

        // 3. Run Die tests
        // DieTest dieTest = new DieTest();
        // dieTest.RunAllTests();

        // 4. Run character unit tests
        // CharacterTest.RunPlayerUnitTest();
        // Console.WriteLine("=== End of Character Unit Tests ===\n");

        // 5. Run dragon unit tests
        // DragonTests dragonTests = new DragonTests();
        // dragonTests.RunAllTests();

        // 6. Run game startup test
        // GameTest gameTest = new GameTest();
        // gameTest.RunAllTests();

        // 7. Run combat system test
        // CombatTests.RunAttackSequenceTest();

        // 8. Run branches unit tests
        // BranchesTests branchesTests = new BranchesTests();
        // branchesTests.RunAllTests();

        // 9. Example use of Die class
        // Die die = new Die();
        // int rollResult = die.Roll(20);
        // Console.WriteLine($"You rolled a dice value of {rollResult}");

        // 10. Start the actual game
        Console.WriteLine("\n=== Game Start ===\n");
        Messages messages = new Messages();
        messages.ReadDictionary("English"); // You can change to "French" or "Spanish"
        Game game = new Game(messages);
        game.StartGame();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
