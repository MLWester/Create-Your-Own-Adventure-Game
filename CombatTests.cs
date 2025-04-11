using System;
using System.IO;
using System.Text;

public class CombatTests
{
    public static void RunAttackSequenceTest()
    {
        // Save original input and output
        var originalIn = Console.In;
        var originalOut = Console.Out;

        // Prepare fake user input: attack, attack, retreat
        string simulatedInput = "a\na\nr\n";
        using var inputReader = new StringReader(simulatedInput);
        Console.SetIn(inputReader);

        // Redirect output to capture what Combat writes
        var outputBuilder = new StringBuilder();
        using var outputWriter = new StringWriter(outputBuilder);
        Console.SetOut(outputWriter);

        // Setup test player and dragon
        Messages messages = new Messages();
        messages.ReadDictionary("English");

        Character testPlayer = new Character("TestPlayer", messages);
        testPlayer.SetOccupation(Occupation.Fighter);
        testPlayer.SetWeapon(new Weapon("Sword", 10, "[-]"));
        testPlayer.SetStrength(15);
        testPlayer.SetAgility(12);
        testPlayer.SetRace(Race.Human);
        testPlayer.SetHealth(25);

        Dragon testDragon = new Dragon("TestDragon", messages);
        testDragon.SetStrength(10);
        testDragon.SetAgility(10);
        testDragon.SetHealth(30);

        // Run the combat
        Combat.AttackSequence(testPlayer, testDragon, messages);


        // Restore original streams
        Console.SetOut(originalOut);
        Console.SetIn(originalIn);

        // Print captured output
        Console.WriteLine("===== Simulated AttackSequence Output =====");
        Console.WriteLine(outputBuilder.ToString());
    }
}
