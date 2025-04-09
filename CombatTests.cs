using System;
using System.IO;
using System.Text;

public class CombatTests
{
    public static void RunAttackSequenceTest()
    {
        // Prepare fake user input: attack, attack, retreat
        string simulatedInput = "a\na\nr\n";
        using var inputReader = new StringReader(simulatedInput);
        Console.SetIn(inputReader);

        // Redirect output to capture what Combat writes
        var outputBuilder = new StringBuilder();
        using var outputWriter = new StringWriter(outputBuilder);
        Console.SetOut(outputWriter);

        // Setup test player and dragon
        Messages messages = new Messages(); // Assuming Messages is implemented
        Character testPlayer = new Character("TestPlayer", messages)
        {
            occupation = Occupation.Fighter,
            weapon = new Weapon("sword", 10, "[-]"),
            strength = 15,
            agility = 12,
            race = Race.Human,
            health = 25
        };

        Messages theMessages = new Messages(); // Assuming Messages is implemented
        Dragon testDragon = new Dragon("TestDragon", theMessages);

        // Run the actual combat sequence
        Combat.AttackSequence(testPlayer, testDragon);

        // Reset Console output so we can print normally again
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        // Show the captured test output
        Console.WriteLine("===== Simulated AttackSequence Output =====");
        Console.WriteLine(outputBuilder.ToString());
    }
}
