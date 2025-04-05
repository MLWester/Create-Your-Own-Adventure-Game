using System;

public class Character
{
    private string name { get; set; }
    private Race? race { get; set; } = null;
    private Occupation? occupation { get; set; } = null;
    private int strength { get; set; }
    private int agility { get; set; }
    private int health { get; set; }
    private Weapon? weapon { get; set; } = null;

    public Character(string name)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));
        CreatePlayerOccupation(); // Automatically call this method to create the character's occupation upon instantiation
        CreatePlayerRace();
        CreatePlayeStrength();
        CreatePlayerAgility();
        CreatePlayerHealth();
    }

    private void CreatePlayerOccupation()
    {
        // Ask for and validate occupation
        Occupation occupation;
        while (true)
        {
            Console.WriteLine("What is the occupation of your character? Fighter, Magician, Thief, or Archer?");
            string? input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(input) && Enum.TryParse(input, true, out occupation) && Enum.IsDefined(typeof(Occupation), occupation))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter one of the following: Fighter, Magician, Thief, or Archer.");
        }
        this.occupation = occupation;

        // Assign weapon based on occupation
        switch (occupation)
        {
            case Occupation.Fighter:
                this.weapon = new Weapon("long sword", 12, "-)=====>");
                break;
            case Occupation.Magician:
                this.weapon = new Weapon("lightning bolt spell", 12, "zap~~~~~~");
                break;
            case Occupation.Thief:
                this.weapon = new Weapon("dagger", 6, "-)==>");
                break;
            case Occupation.Archer:
                this.weapon = new Weapon("long bow", 8, "} -->");
                break;
        }

        if (this.weapon != null) // Ensure weapon is not null before accessing its properties
        {
            Console.WriteLine($"You have chosen {this.occupation} and your weapon is {this.weapon.Type}.");
            Console.WriteLine($"Weapon ASCII Art: {this.weapon.AsciiArt}");
        }
    }

    private void CreatePlayerRace()
    {
        // Ask for and validate race
        Race race;
        while (true)
        {
            Console.WriteLine("What is the race of your character? Elf, Human, Dwarf, or Halfling?");
            string? input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(input) && Enum.TryParse(input, true, out race) && Enum.IsDefined(typeof(Race), race))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter one of the following: Elf, Human, Dwarf, or Halfling.");
        }
        this.race = race;

        Console.WriteLine($"You have chosen {this.race} as your race.");
    }

    private void CreatePlayeStrength()
    {
        Die die = new Die();
        // Roll for strength
        Console.WriteLine("Next, we are going to roll for strength. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
        {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for strength.");
        }
        int strength = die.Roll(6);
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf)
        {
            strength += die.Roll(4); // Add modifier for Human, Elf, Dwarf
        }
        else if (race == Race.Halfling)
        {
            strength -= die.Roll(4); // Subtract modifier for Halfling
        }
        this.strength = strength;
    }

    private void CreatePlayerAgility()
    {
        Die die = new Die();
        // Roll for agility
        Console.WriteLine("Next, we will roll for agility. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
        {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for agility.");
        }
        int agility = die.Roll(6);
        if (race == Race.Halfling || race == Race.Elf)
        {
            agility += die.Roll(4); // Add modifier for Halfling, Elf
        }
        this.agility = agility;
    }

    private void CreatePlayerHealth()
    {
        Die die = new Die();
        // Roll for health
        Console.WriteLine("Next, we will roll for health points. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
        {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for health points.");
        }
        int health = die.Roll(6);
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf)
        {
            health += strength; // Add strength modifier for Human, Elf, Dwarf
        }
        this.health = health;

        // Display character stats
        Console.WriteLine($"Your character stats are: Strength: {this.strength}, Agility: {this.agility}, Health: {this.health}");
    }

    public string MissedMeTaunt()
    {
        return "The dragon missed you.";
    }

    public string WasHitTaunt()
    {
        return "(Dragon.name) hits you."; // Ensure Dragon.name is handled properly in the future
    }

    public string DisplayStats()
    {
        return $"Name: {name}\n" +
               $"Race: {race?.ToString() ?? "None"}\n" +
               $"Occupation: {occupation?.ToString() ?? "None"}\n" +
               $"Strength: {strength}\n" +
               $"Agility: {agility}\n" +
               $"Health: {health}\n" +
               $"Weapon: {(weapon != null ? weapon.Type : "None")}";
    }

    public Weapon? GetWeapon()
    {
        return weapon;
    }

    public void SetWeapon(Weapon? weapon)
    {
        this.weapon = weapon;
    }

    public int GetStrength()
    {
        return strength;
    }

    public void SetStrength(int strength)
    {
        this.strength = strength;
    }

    public int GetAgility()
    {
        return agility;
    }

    public void SetAgility(int agility)
    {
        this.agility = agility;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public Race? GetRace()
    {
        return race;
    }

    public void SetRace(Race? race)
    {
        this.race = race;
    }

    public Occupation? GetOccupation()
    {
        return occupation;
    }

    public void SetOccupation(Occupation? occupation)
    {
        this.occupation = occupation;
    }
}

