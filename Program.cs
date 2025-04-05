Console.WriteLine("=== Manual Unit Test Runner ===\n");

// Call test from WeaponTest.cs (no conflict now)
WeaponTest.RunWeaponUnitTests();
DieTest tester = new DieTest();
tester.RunAllTests();
DragonTests dragonTests = new DragonTests();
dragonTests.RunAllTests(); // Run all dragon tests
GameTest gameTest = new GameTest();
gameTest.RunAllTests();




//Example use of Die class and roll method
Die die = new Die();
int rollResult = die.Roll(20);
System.Console.WriteLine($"You rolled a dice value of {rollResult}");

Console.WriteLine("\n=== Game Start ===\n");
Game game = new Game();
game.StartGame();


//Call test from CharacterTest.cs (no conflict now)
CharacterTest.RunPlayerUnitTest();
Console.WriteLine("=== End of Unit Tests ===\n");
Console.WriteLine("Press any key to exit...");