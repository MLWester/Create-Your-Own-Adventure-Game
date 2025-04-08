using System;

public class Player : Character
{
    public new Occupation? Occupation { get; set; }
    public new Weapon? Weapon { get; set; }
    public new Race? Race { get; set; }
    public new int Strength { get; set; }
    public new int Agility { get; set; }
    public new int Health { get; set; }

    private Messages Messages { get; }

    public Player(string name, Messages messages) : base(name, messages)
    {
        Messages = messages;

        // Initialize default values
        Strength = 0;
        Agility = 0;
        Health = 0;
        Weapon = null;
        Occupation = null;
        Race = null;

        // Trigger the character creation logic
        CreateCharacterInteractive();
    }

    // If needed, you can override methods from Character class here later
}
