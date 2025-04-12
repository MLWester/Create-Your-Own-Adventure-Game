using System;

public class Character
{
    public string name { get; set; }
    public Race? race { get; set; } = null;
    public Occupation? occupation { get; set; } = null;
    public int strength { get; set; }
    public int agility { get; set; }
    public int health { get; set; }
    public Weapon? weapon { get; set; } = null;
    public Messages messages;

    // Constructor only assigns name and messages — does not auto-run creation steps
    public Character(string name, Messages messages)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));
        this.messages = messages ?? throw new ArgumentNullException(nameof(messages));
    }

    // Call this method after creating a Character to begin user input prompts
    public void CreateCharacterInteractive()
    {
        CreatePlayerOccupation(); // Ask and validate occupation
        CreatePlayerRace();       // Ask and validate race
        CreatePlayerStrength();   // Roll for strength
        CreatePlayerAgility();    // Roll for agility
        CreatePlayerHealth();     // Roll for health and print final stats
    }

    private void CreatePlayerOccupation()
    {
        {
            var occupationMap = messages.GetLocalizedOccupationMap();
            Occupation occ;

            while (true)
            {
                Console.WriteLine(messages.GetMessage(101));
                string? input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) && occupationMap.TryGetValue(input, out occ))
                    break;

                Console.WriteLine(messages.GetMessage(102));
            }

            this.occupation = occ;

            // Assign weapon based on occupation
            weapon = occ switch
            {
                Occupation.Fighter => new Weapon("long sword", 12, "-)=====>"),
                Occupation.Magician => new Weapon("lightning bolt spell", 12, "zap~~~~~~"),
                Occupation.Thief => new Weapon("dagger", 6, "-)==>"),
                Occupation.Archer => new Weapon("long bow", 8, "} -->"),
                _ => null
            };

            if (weapon != null)
            {
                Console.WriteLine(string.Format(messages.GetMessage(103), this.occupation, weapon.Type));
                Console.WriteLine(string.Format(messages.GetMessage(104), weapon.AsciiArt));
            }
        }
    }

    private void CreatePlayerRace()
    {
        // Ask for and validate race
        var raceMap = messages.GetLocalizedRaceMap();
        Race r;

        while (true)
        {
            Console.WriteLine(messages.GetMessage(105));
            string? input = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(input) && raceMap.TryGetValue(input, out r))
                break;

            Console.WriteLine(messages.GetMessage(106));
        }

        this.race = r;
        Console.WriteLine(string.Format(messages.GetMessage(107), race));
    }

    private void CreatePlayerStrength()
    {
        Die die = new Die();
        Console.WriteLine(messages.GetMessage(108));
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
            Console.WriteLine(messages.GetMessage(109));

        int str = die.Roll(20);
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf)
            str += die.Roll(4);
        else if (race == Race.Halfling)
            str -= die.Roll(4);

        this.strength = str;
    }

    private void CreatePlayerAgility()
    {
        Die die = new Die();
        Console.WriteLine(messages.GetMessage(110));
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
            Console.WriteLine(messages.GetMessage(111));

        int agi = die.Roll(20);
        if (race == Race.Halfling || race == Race.Elf)
            agi += die.Roll(4);

        this.agility = agi;
    }

    private void CreatePlayerHealth()
    {
        Die die = new Die();
        Console.WriteLine(messages.GetMessage(112));
        while (Console.ReadLine()?.Trim().ToLower() != "roll")
            Console.WriteLine(messages.GetMessage(113));

        int hp = die.Roll(20);
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf)
            hp += strength;

        this.health = hp;
        Console.WriteLine(string.Format(messages.GetMessage(114), strength, agility, health));
    }

    // Dragon taunts
    public string MissedMeTaunt() => messages.GetMessage(301);
    public string WasHitTaunt() => messages.GetMessage(305);

    // Display character stats as string
    public string DisplayStats()
    {
        string raceLabel = race.HasValue ? messages.GetLocalizedRaceLabel(race.Value) : "None";
        string occupationLabel = occupation.HasValue ? messages.GetLocalizedOccupationLabel(occupation.Value) : "None";

        return $"{messages.GetMessage(115)}{name}\n" +
            $"{messages.GetMessage(116)} {raceLabel}\n" +
            $"{messages.GetMessage(117)} {occupationLabel}\n" +
            $"{messages.GetMessage(118)} {strength}\n" +
            $"{messages.GetMessage(119)} {agility}\n" +
            $"{messages.GetMessage(120)} {health}\n" +
            $"{messages.GetMessage(121)} {(weapon != null ? weapon.Type : "None")}";
    }

    // Accessors and setters for stats and properties
    public Weapon? GetWeapon() => weapon;
    public void SetWeapon(Weapon? weapon) => this.weapon = weapon;
    public int GetStrength() => strength;
    public void SetStrength(int value) => strength = value;
    public int GetAgility() => agility;
    public void SetAgility(int value) => agility = value;
    public int GetHealth() => health;
    public void SetHealth(int value) => health = value;
    public Race? GetRace() => race;
    public void SetRace(Race? value) => race = value;
    public Occupation? GetOccupation() => occupation;
    public void SetOccupation(Occupation? value) => occupation = value;
}
