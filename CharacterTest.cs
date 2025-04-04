
using System;

public static class CharacterTest
{
    public static void RunPlayerUnitTest()
    {
        // Test 1: Create a Player object using the parameterized constructor.
        Character testCharacter = new Character("TestName", "Human", "Warrior");
        Console.WriteLine("Test 1: Player Initialization");
        Console.WriteLine(testCharacter.DisplayStats());
        Console.WriteLine();

        // Assert initial values
        if (testCharacter.name != "TestName") Console.WriteLine("Test 1 Failed: Name mismatch.");
        if (testCharacter.strength != 0) Console.WriteLine("Test 1 Failed: Strength mismatch.");
        if (testCharacter.agility != 0) Console.WriteLine("Test 1 Failed: Agility mismatch.");
        if (testCharacter.health != 0) Console.WriteLine("Test 1 Failed: Health mismatch.");
        if (testCharacter.weapon != null) Console.WriteLine("Test 1 Failed: Weapon should be null.");
        Console.WriteLine("Test 1 Passed.");
        Console.WriteLine();

        // Test 2: Equip a weapon and verify.
        Weapon testWeapon = new Weapon("Sword", 20, "⚔️");
        testCharacter.weapon = testWeapon;
        Console.WriteLine("Test 2: Equip Weapon");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.weapon != testWeapon) Console.WriteLine("Test 2 Failed: Weapon mismatch.");
        Console.WriteLine("Test 2 Passed.");
        Console.WriteLine();

        // Test 3: Modify stats and verify.
        testCharacter.strength += 5;
        testCharacter.agility += 3;
        testCharacter.health -= 10;
        Console.WriteLine("Test 3: Modify Stats");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.strength != 5) Console.WriteLine("Test 3 Failed: Strength mismatch.");
        if (testCharacter.agility != 3) Console.WriteLine("Test 3 Failed: Agility mismatch.");
        if (testCharacter.health != -10) Console.WriteLine("Test 3 Failed: Health mismatch.");
        Console.WriteLine("Test 3 Passed.");
        Console.WriteLine();

        // Test 4: Display taunts.
        Console.WriteLine("Test 4: Taunts");
        Console.WriteLine(testCharacter.MissedMeTaunt());
        Console.WriteLine(testCharacter.WasHitTaunt());
        Console.WriteLine("Test 4 Passed.");
        Console.WriteLine();
    }
}
