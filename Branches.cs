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
        Console.WriteLine(messages.GetMessage(401)); // Adventure menu
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
        Console.WriteLine(messages.GetMessage(403)); // South path message
        // I don't think this message needs to be here. It says "Character creation starting..." We could just let it go back to the menu or change it.
        Console.WriteLine(messages.GetMessage(205)); // Return to menu
        DisplayAdventureMenu();
    }

    private void NorthPath()
    {
        Console.WriteLine(messages.GetMessage(402)); // North path intro
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Format(messages.GetMessage(405), dragon.GetName())); // Dragon intro
        Console.ResetColor();
        //Console.WriteLine(messages.GetMessage(208)); // Dragon stats
        Console.WriteLine(dragon.DisplayStats());
        Console.WriteLine("Options: “r” for retreat and “a” for attack"); // this retreat option needs to be redone so that the corresponding message from Messages.cs but I'm don't want to mess anything up by merging the main branch into it yet.

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
