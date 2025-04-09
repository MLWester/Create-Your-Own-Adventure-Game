using System;

public class Dragon
{
    private string Name { get; set; }
    private int Strength { get; set; }
    private int Health { get; set; }
    private int Agility { get; set; }
    private Weapon Weapon { get; set; }
    private Messages Messages { get; set; }
    private Random random = new Random();

    public Dragon(string name, Messages messages)
    {
        Name = name;
        Messages = messages;
        Strength = new Die().Roll(20);
        Agility = new Die().Roll(20);
        Health = new Die().Roll(20);
        Weapon = new Weapon("claws", 12, "##");
    }

    public string MissedMeTaunt()
    {
        int key = 301 + random.Next(0, 4); // 301–304
        return Messages.GetMessage(key);
    }

    public string WasHitTaunt()
    {
        int key = 305 + random.Next(0, 4); // 305–308
        return Messages.GetMessage(key);
    }

    public string DisplayStats()
    {
        return string.Format(Messages.GetMessage(309), Name, Strength, Health, Agility, Weapon.Type, Weapon.MaxDamage);
    }

    // Getter methods
    public string GetName() => Name;
    public int GetStrength() => Strength;
    public int GetHealth() => Health;
    public int GetAgility() => Agility;
    public Weapon GetWeapon() => Weapon;

    // Setter methods for testing
    public void SetStrength(int value) => Strength = value;
    public void SetAgility(int value) => Agility = value;
    public void SetHealth(int value) => Health = value;
}
