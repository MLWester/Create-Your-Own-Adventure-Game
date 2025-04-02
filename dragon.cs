using System;

public class Dragon {
    private string Name { get; set; }
    private int Strength { get; set; }
    private int Health { get; set; }
    private int Agility { get; set; }
    private Weapon Weapon { get; set; }

    private Random random = new Random();

    public Dragon(string name) {
        Name = name;
        Strength = new Die().Roll(20); // Roll for strength
        Agility = new Die().Roll(20); // Roll for agility
        Health = new Die().Roll(20);  // Roll for health
        Weapon = new Weapon("claws", 12, "##"); // Updated weapon initialization
    }
    
    public string MissedMeTaunt() {
        string[] taunts = { "Missed me, breath of a gnat!", "Is that all you've got? I've seen kittens with more fire in their paws!", "Try harder, human! You're making me yawn!", "Maybe if you squinted harder, you'd actually hit something!" };
        return taunts[random.Next(taunts.Length)];
    }

    public string WasHitTaunt() {
        string[] taunts = { "Ow! That actually stung a bit!", "Impressive! You might actually be worth toasting...", "That... was unexpected. But I assure you, it won't happen again.", "Well, I'll be! You have more bite than I thought!" };
        return taunts[random.Next(taunts.Length)];
    }

    public string DisplayStats() {
        return $"Name: {Name}, Strength: {Strength}, Health: {Health}, Agility: {Agility}, Weapon: {Weapon.Type} (Max Damage: {Weapon.MaxDamage})";
    }
}