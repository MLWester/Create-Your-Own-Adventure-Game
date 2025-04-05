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

    private void TestDragonInitialization()
    {
        Dragon dragon = new Dragon("Smaug");
        bool isInitialized = !string.IsNullOrEmpty(dragon.DisplayStats());
        Console.WriteLine("Dragon test 1 - initialization test: " + (isInitialized ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestMissedMeTaunt()
    {
        Dragon dragon = new Dragon("Smaug");
        string taunt = dragon.MissedMeTaunt();
        bool isValidTaunt = !string.IsNullOrEmpty(taunt);
        Console.WriteLine("Dragon test 2 - missed me taunt test: " + (isValidTaunt ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestWasHitTaunt()
    {
        Dragon dragon = new Dragon("Smaug");
        string taunt = dragon.WasHitTaunt();
        bool isValidTaunt = !string.IsNullOrEmpty(taunt);
        Console.WriteLine("Dragon test 3 - was hit taunt test: " + (isValidTaunt ? "✅ PASS" : "❌ FAIL"));
    }

    private void TestDisplayStats()
    {
        Dragon dragon = new Dragon("Smaug");
        string stats = dragon.DisplayStats();
        bool isValidStats = stats.Contains("Name: Smaug") && stats.Contains("Strength:") && stats.Contains("Health:") && stats.Contains("Agility:") && stats.Contains("Weapon:");
        Console.WriteLine("Dragon test 4 - display stats test: " + (isValidStats ? "✅ PASS" : "❌ FAIL"));
    }
}