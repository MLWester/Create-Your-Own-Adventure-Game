using System;

public class Branches
{
    private Character player;
    private Dragon dragon;
    private Messages messages;

    public Branches(Character player, Dragon dragon, Messages messages)
    {
        this.player = player;
        this.dragon = dragon;
        this.messages = messages;
    }

    public void DisplayAdventureMenu()
    {
        Console.WriteLine(messages.GetMessage(201)); // Intro message
        Console.WriteLine(messages.GetMessage(202)); // Menu options
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
                Console.WriteLine(messages.GetMessage(203)); // Invalid choice
                DisplayAdventureMenu();
                break;
        }
    }

    private void SouthPath()
    {
        Console.WriteLine(messages.GetMessage(204)); // South path message
        Console.WriteLine(messages.GetMessage(205)); // Return to menu
        DisplayAdventureMenu();
    }

    private void NorthPath()
    {
        Console.WriteLine(messages.GetMessage(206)); // North path intro
        Console.WriteLine("You have chosen to take the North path. Prepare yourself!"); // Confirmation message
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Format(messages.GetMessage(207), dragon.GetName())); // Dragon intro
        Console.ResetColor();
        Console.WriteLine(messages.GetMessage(208)); // Dragon stats
        Console.WriteLine(dragon.DisplayStats());
        Console.WriteLine(messages.GetMessage(209)); // Retreat or attack

        string choice = Console.ReadLine()?.ToLower();
        if (choice == "r")
        {
            Retreat();
        }
        else if (choice == "a")
        {
            Combat.AttackSequence(player, dragon, messages); // Trigger combat
        }
        else
        {
            Console.WriteLine(messages.GetMessage(203)); // Invalid choice
            NorthPath();
        }
    }

    private void Retreat()
    {
        Console.WriteLine(messages.GetMessage(318)); // Retreat message
        EndGame();
    }

    private void EndGame()
    {
        Console.WriteLine(messages.GetMessage(204)); // End game message
        Environment.Exit(0);
    }
}
