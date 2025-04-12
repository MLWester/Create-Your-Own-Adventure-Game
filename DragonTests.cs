using System;

public class DragonTests
{
    public void RunAllTests()
    {
        TestDragonInitialization();
        TestMissedMeTaunt();
        TestWasHitTaunt();
        TestDisplayStats();
    }

    private Messages SetupMessages()
    {
        Messages messages = new Messages();
        messages.ReadDictionary("English");
        return messages;
    }

    private void TestDragonInitialization()
    {
        Messages messages = SetupMessages();
        Dragon dragon = new Dragon("Smaug", messages);
        bool isInitialized = !string.IsNullOrEmpty(dragon.DisplayStats());
        Console.WriteLine("Dragon test 1 - initialization test: " + (isInitialized ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestMissedMeTaunt()
    {
        Messages messages = SetupMessages();
        Dragon dragon = new Dragon("Smaug", messages);
        string taunt = dragon.MissedMeTaunt();
        bool isValidTaunt = !string.IsNullOrEmpty(taunt);
        Console.WriteLine("Dragon test 2 - missed me taunt test: " + (isValidTaunt ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestWasHitTaunt()
    {
        Messages messages = SetupMessages();
        Dragon dragon = new Dragon("Smaug", messages);
        string taunt = dragon.WasHitTaunt();
        bool isValidTaunt = !string.IsNullOrEmpty(taunt);
        Console.WriteLine("Dragon test 3 - was hit taunt test: " + (isValidTaunt ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestDisplayStats()
    {
        Messages messages = SetupMessages();
        Dragon dragon = new Dragon("Smaug", messages);
        string stats = dragon.DisplayStats();

        bool hasName = stats.Contains(dragon.GetName());
        bool hasWeapon = stats.Contains(dragon.GetWeapon().Type);
        bool hasKeywordStrength = stats.ToLower().Contains("strength") || stats.ToLower().Contains("force") || stats.ToLower().Contains("fuerza");
        bool hasKeywordHealth = stats.ToLower().Contains("health") || stats.ToLower().Contains("santé") || stats.ToLower().Contains("salud");
        bool hasKeywordAgility = stats.ToLower().Contains("agility") || stats.ToLower().Contains("agilité") || stats.ToLower().Contains("agilidad");

        bool isValidStats = hasName && hasWeapon && hasKeywordStrength && hasKeywordHealth && hasKeywordAgility;

        Console.WriteLine("Dragon test 4 - display stats test: " + (isValidStats ? "✅ PASS" : "❌ FAIL"));
    }
}
