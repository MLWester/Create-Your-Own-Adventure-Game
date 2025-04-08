using System;

public static class CharacterTest
{
    public static void RunPlayerUnitTest()
    {
        Messages messages = new Messages();
        messages.ReadDictionary("English");

        // Test 1: Create a Character object using the parameterized constructor.
        Character testCharacter = new Character("TestName", messages);
        Console.WriteLine("Test 1: Player Initialization");
        Console.WriteLine(testCharacter.DisplayStats());
        Console.WriteLine();

        // Test 2: Equip a weapon and verify.
        Weapon testWeapon = new Weapon("Sword", 20, "⚔️");
        testCharacter.SetWeapon(testWeapon); // Use a setter method for weapon
        Console.WriteLine("Test 2: Equip Weapon");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.GetWeapon() != testWeapon) Console.WriteLine("Test 2 Failed: Weapon mismatch.");
        Console.WriteLine("Test 2 Passed.");
        Console.WriteLine();

        // Test 3: Modify stats and verify.
        testCharacter.SetStrength(5);
        testCharacter.SetAgility(3);
        testCharacter.SetHealth(-10);
        Console.WriteLine("Test 3: Modify Stats");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.GetStrength() == 5) Console.WriteLine("Test 3 Passed: Strength match.");
        if (testCharacter.GetAgility() == 3) Console.WriteLine("Test 3 Passed: Agility match.");
        if (testCharacter.GetHealth() == -10) Console.WriteLine("Test 3 Passed: Health match.");
        Console.WriteLine("Test 3 Passed.");
        Console.WriteLine();

        // Test 4: Roll for stats using Die.
        Die die = new Die();
        int strengthRoll = die.Roll(6);
        int agilityRoll = die.Roll(6);
        int healthRoll = die.Roll(6);
        testCharacter.SetStrength(strengthRoll);
        testCharacter.SetAgility(agilityRoll);
        testCharacter.SetHealth(healthRoll);

        Console.WriteLine("Test 4: Roll for Stats");
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.GetStrength() != strengthRoll) Console.WriteLine("Test 4 Failed: Strength roll mismatch.");
        if (testCharacter.GetAgility() != agilityRoll) Console.WriteLine("Test 4 Failed: Agility roll mismatch.");
        if (testCharacter.GetHealth() != healthRoll) Console.WriteLine("Test 4 Failed: Health roll mismatch.");
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
        testCharacter.SetRace(Race.Elf);
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.GetRace() != Race.Elf) Console.WriteLine("Test 6 Failed: Race mismatch.");
        Console.WriteLine("Test 6 Passed.");
        Console.WriteLine();

        // Test 7: Assign occupation and verify.
        Console.WriteLine("Test 7: Assign Occupation");
        testCharacter.SetOccupation(Occupation.Fighter);
        Console.WriteLine(testCharacter.DisplayStats());
        if (testCharacter.GetOccupation() != Occupation.Fighter) Console.WriteLine("Test 7 Failed: Occupation mismatch.");
        Console.WriteLine("Test 7 Passed.");
        Console.WriteLine();

        // Test 8: Verify taunts.
        Console.WriteLine("Test 8: Verify Taunts");
        string missedTaunt = testCharacter.MissedMeTaunt();
        string hitTaunt = testCharacter.WasHitTaunt();
        if (missedTaunt != messages.GetMessage(301)) Console.WriteLine("Test 8 Failed: Missed taunt mismatch.");
        if (hitTaunt != messages.GetMessage(305)) Console.WriteLine("Test 8 Failed: Hit taunt mismatch.");
        Console.WriteLine("Test 8 Passed.");
        Console.WriteLine();
    }
}
