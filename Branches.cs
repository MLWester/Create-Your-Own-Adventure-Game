using System;

public class Branches
{
    public void DisplayAdventureMenu()
    {
        Console.WriteLine("You are walking in the mountains...");
        Console.WriteLine("Enter 'n' for North. Enter 's' for South. Enter 'e' for exit game.");
        string choice = Console.ReadLine()?.ToLower();

        switch (choice)
        {
            case "n":
                NorthPath();
                break;
            case "s":
                SouthPath();
                break;
            case "e":
                EndGame();
                break;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                DisplayAdventureMenu();
                break;
        }
    }

    private void SouthPath()
    {
        Console.WriteLine("You take the South path... still bored.");
        Console.WriteLine("Returning to the main menu...");
        DisplayAdventureMenu();
    }

    private void NorthPath()
    {
        Console.WriteLine("You take the North path... The dragon has a hoard of gold behind it.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The dragon says 'I am the mighty dragon. Leave or perish!'");
        Console.ResetColor();
        Console.WriteLine("Your magic ring gives you the stats on the dragon.");
        Console.WriteLine("Dragon Stats: Strength: 15, Agility: 10, Health: 20");
        Console.WriteLine("Do you wish to retreat or attack? Enter 'r' for retreat. Enter 'a' for attack.");
        string choice = Console.ReadLine()?.ToLower();

        if (choice == "r")
        {
            Retreat();
        }
        else if (choice == "a")
        {
            Attack();
        }
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            NorthPath();
        }
    }

    private void Retreat()
    {
        Console.WriteLine("You chose to retreat. The dragon lets you go this time.");
        EndGame();
    }

    private void Attack()
    {
        Console.WriteLine("You chose to attack the dragon!");
        Console.WriteLine("Combat sequence initiated...");
        // Simulate combat sequence
        Console.WriteLine("...combat logic here...");
        EndGame();
    }

    private void EndGame()
    {
        Console.WriteLine("Thank you for playing. The game has ended.");
        Environment.Exit(0);
    }
}
