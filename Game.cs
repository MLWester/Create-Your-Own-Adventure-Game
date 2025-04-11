using System;

public class Game
{
    private Die die;
    private Messages messages;
    private Character? player;

    public Game(Messages messages)
    {
        this.messages = messages ?? throw new ArgumentNullException(nameof(messages));
        this.die = new Die();
    }

    public void StartGame()
    {
        Console.WriteLine("Choose a language / Choisissez une langue / Elige un idioma:");
        Console.WriteLine("1. English");
        Console.WriteLine("2. French");
        Console.WriteLine("3. Spanish");
        

        string? langChoice = Console.ReadLine()?.Trim();
        Console.WriteLine();

        string selectedLang = langChoice switch
        {
            "2" => "French",
            "3" => "Spanish",
            _ => "English"
        };

        messages.ReadDictionary(selectedLang);

        Console.WriteLine(messages.GetMessage(201)); // Welcome

        string input;

        // Loop until valid input is received
        while (true)
        {
            Console.WriteLine(messages.GetMessage(202)); // Menu prompt
            input = Console.ReadLine()?.Trim() ?? "";

            if (input == "1" || input == "2")
                break;

            Console.WriteLine(messages.GetMessage(203)); // Invalid input
        }

        if (input == "2")
        {
            Console.WriteLine(messages.GetMessage(204)); // Exit message
            return;
        }

        Console.WriteLine(messages.GetMessage(205)); // Starting character creation
        Console.WriteLine(messages.GetMessage(206)); // Ask for name
        string name = Console.ReadLine() ?? "Unnamed Hero";

        player = new Character(name, messages);
        player.CreateCharacterInteractive();

        Console.WriteLine(messages.GetMessage(209)); // Character successfully created
        Console.WriteLine("\n--- Final Stats ---");
        Console.WriteLine(player.DisplayStats());

        // Future: Continue to dragon combat, etc.

        // ===== Begin Combat Section =====
        Dragon dragon = new Dragon("Smaug", messages);
        Combat.AttackSequence(player, dragon, messages);
    } 
}