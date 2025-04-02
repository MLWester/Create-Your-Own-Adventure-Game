public class CharacterCreation {
    public Player CreatePlayerOccupation(Player player) {
        // Ask for and validate occupation
        Occupation occupation;
        while (true) {
            Console.WriteLine("What is the occupation of your character? Fighter, Magician, Thief, or Archer?");
            string input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(input) && Enum.TryParse(input, true, out occupation) && Enum.IsDefined(typeof(Occupation), occupation)) {
                break;
            }
            Console.WriteLine("Invalid input. Please enter one of the following: Fighter, Magician, Thief, or Archer.");
        }
        player.Occupation = occupation;

        // Assign weapon based on occupation
        switch (occupation) {
            case Occupation.Fighter:
                player.Weapon = new Weapon("long sword", 12, "-)=====>");
                break;
            case Occupation.Magician:
                player.Weapon = new Weapon("lightning bolt spell", 12, "zap~~~~~~");
                break;
            case Occupation.Thief:
                player.Weapon = new Weapon("dagger", 6, "-)==>");
                break;
            case Occupation.Archer:
                player.Weapon = new Weapon("long bow", 8, "} -->");
                break;
        }

        Console.WriteLine($"You have chosen {player.Occupation} and your weapon is {player.Weapon.Type}.");
        Console.WriteLine($"Weapon ASCII Art: {player.Weapon.AsciiArt}");

        // Ask for and validate race
        Race race;
        while (true) {
            Console.WriteLine("What is the race of your character? Elf, Human, Dwarf, or Halfling?");
            string input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(input) && Enum.TryParse(input, true, out race) && Enum.IsDefined(typeof(Race), race)) {
                break;
            }
            Console.WriteLine("Invalid input. Please enter one of the following: Elf, Human, Dwarf, or Halfling.");
        }
        player.Race = race;

        Console.WriteLine($"You have chosen {player.Race} as your race.");

        Die die = new Die();

        // Roll for strength
        Console.WriteLine("Next, we are going to roll for strength. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll") {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for strength.");
        }
        int strength = die.Roll();
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf) {
            strength += die.Roll(4); // Add modifier for Human, Elf, Dwarf
        } else if (race == Race.Halfling) {
            strength -= die.Roll(4); // Subtract modifier for Halfling
        }
        player.Strength = strength;

        // Roll for agility
        Console.WriteLine("Next, we will roll for agility. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll") {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for agility.");
        }
        int agility = die.Roll();
        if (race == Race.Halfling || race == Race.Elf) {
            agility += die.Roll(4); // Add modifier for Halfling, Elf
        }
        player.Agility = agility;

        // Roll for health
        Console.WriteLine("Next, we will roll for health points. Type ‘roll’");
        while (Console.ReadLine()?.Trim().ToLower() != "roll") {
            Console.WriteLine("Invalid input. Please type 'roll' to roll for health points.");
        }
        int health = die.Roll();
        if (race == Race.Human || race == Race.Elf || race == Race.Dwarf) {
            health += strength; // Add strength modifier for Human, Elf, Dwarf
        }
        player.Health = health;

        // Display character stats
        Console.WriteLine($"Your character stats are: Strength: {player.Strength}, Agility: {player.Agility}, Health: {player.Health}");

        return player;
    }
}