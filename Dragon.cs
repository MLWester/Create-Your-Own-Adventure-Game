using System;

public class Dragon
{
    private string Name { get; set; }
    private int Strength { get; set; }
    private int Health { get; set; }
    private int Agility { get; set; }
    private Weapon Weapon { get; set; }

    private readonly Random random = new Random();
    private readonly Messages messages;

    // Constructor with Messages dependency
    public Dragon(string name, Messages messages)
    {
        this.Name = name;
        this.messages = messages;

        Die die = new Die();
        Strength = die.Roll(20);  // Roll for strength
        Agility = die.Roll(20);   // Roll for agility
        Health = die.Roll(20);    // Roll for health
        Weapon = new Weapon("claws", 12, "##");
    }

    // Returns a random taunt when the dragon is missed
    public string MissedMeTaunt()
    {
        int[] missedTauntKeys = { 301, 302, 303, 304 };
        int randomKey = missedTauntKeys[random.Next(missedTauntKeys.Length)];
        return messages.GetMessage(randomKey);
    }

    // Returns a random taunt when the dragon is hit
    public string WasHitTaunt()
    {
        int[] hitTauntKeys = { 305, 306, 307, 308 };
        int randomKey = hitTauntKeys[random.Next(hitTauntKeys.Length)];
        return messages.GetMessage(randomKey);
    }

    // Displays the dragon's stats using a formatted message
    public string DisplayStats()
    {
        return string.Format(
            messages.GetMessage(309),
            Name,
            Strength,
            Health,
            Agility,
            Weapon.Type,
            Weapon.MaxDamage
        );
    }

    // Getters for use in combat or test logic
    public int GetStrength() => Strength;
    public int GetHealth() => Health;
    public int GetAgility() => Agility;
    public string GetName() => Name;
    public Weapon GetWeapon() => Weapon;

    public void SetHealth(int hp) => Health = hp;
}
