Console.WriteLine("=== Manual Unit Test Runner ===\n");

// Call test from WeaponTest.cs (no conflict now)
WeaponTest.RunWeaponUnitTests();
DieTest tester = new DieTest();
tester.RunAllTests();




//Example use of Die class and roll method
Die die = new Die();
int rollResult = die.Roll(20);
System.Console.WriteLine($"You rolled a dice value of {rollResult}");


Game game = new Game();
game.StartGame();



