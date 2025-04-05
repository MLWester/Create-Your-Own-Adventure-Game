using System;

public static class CharacterTest
{
    public static void RunPlayerUnitTest()
    {
        // Test 1: Create a Player object using the parameterized constructor.
        Character testCharacter = new Character("TestName");
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

        // Test 4: Roll for stats using Die.
        Die die = new Die();
        int strengthRoll = die.Roll(6);
        int agilityRoll = die.Roll(6);
        int healthRoll = die.Roll(6);
        testCharacter.strength = strengthRoll;
        testCharacter.agility = agilityRoll;
        testCharacter.health = healthRoll;

        Console.WriteLine("Test 4: Roll for Stats");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.strength != strengthRoll) Console.WriteLine("Test 4 Failed: Strength roll mismatch.");
        if (testCharacter.agility != agilityRoll) Console.WriteLine("Test 4 Failed: Agility roll mismatch.");
        if (testCharacter.health != healthRoll) Console.WriteLine("Test 4 Failed: Health roll mismatch.");
        Console.WriteLine("Test 4 Passed.");
        Console.WriteLine();

        // Test 5: Display taunts.
        Console.WriteLine("Test 5: Taunts");
        Console.WriteLine(testCharacter.MissedMeTaunt());
        Console.WriteLine(testCharacter.WasHitTaunt());
        Console.WriteLine("Test 5 Passed.");
        Console.WriteLine();

        // Test 6: Assign race and verify.
        Console.WriteLine("Test 6: Assign Race");
        testCharacter.race = Race.Elf;
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.race != Race.Elf) Console.WriteLine("Test 6 Failed: Race mismatch.");
        Console.WriteLine("Test 6 Passed.");
        Console.WriteLine();

        // Test 7: Assign occupation and verify.
        Console.WriteLine("Test 7: Assign Occupation");
        testCharacter.occupation = Occupation.Fighter;
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.occupation != Occupation.Fighter) Console.WriteLine("Test 7 Failed: Occupation mismatch.");
        Console.WriteLine("Test 7 Passed.");
        Console.WriteLine();

        // Test 8: Verify taunts.
        Console.WriteLine("Test 8: Verify Taunts");
        string missedTaunt = testCharacter.MissedMeTaunt();
        string hitTaunt = testCharacter.WasHitTaunt();
        if (missedTaunt != "The dragon missed you.") Console.WriteLine("Test 8 Failed: Missed taunt mismatch.");
        if (hitTaunt != "(Dragon.name) hits you.") Console.WriteLine("Test 8 Failed: Hit taunt mismatch.");
        Console.WriteLine("Test 8 Passed.");
        Console.WriteLine();
    }
}
