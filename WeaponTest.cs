public static class WeaponTest
{
    public static void RunWeaponUnitTests()
    {
        Console.WriteLine("Running Weapon Class Tests...\n");

        Weapon testWeapon = new Weapon("dagger", 6, "/>");

        // Test 1: Constructor assigns values correctly
        bool test1 = testWeapon.Type == "dagger" &&
                     testWeapon.MaxDamage == 6 &&
                     testWeapon.AsciiArt == "/>";
        Console.WriteLine("Test 1 - Constructor Assignments: " + (test1 ? "✅ PASS" : "❌ FAIL"));

        // Test 2: Display() returns expected string
        string expected = "/> (dagger) - Max Damage: 6";
        string actual = testWeapon.Display();
        bool test2 = actual == expected;
        Console.WriteLine("Test 2 - Display Method Output: " + (test2 ? "✅ PASS" : $"❌ FAIL\nExpected: {expected}\nActual: {actual}"));
    }
}

