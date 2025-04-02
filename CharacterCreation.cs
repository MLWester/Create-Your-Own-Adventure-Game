public class CharacterCreation{
    public Player CreatePlayerOccupation(Player player)
    {
        Console.WriteLine("What is the occupation of your character? Fighter, Magician, Thief, or Archer?");
        Occupation occupation = (Occupation)Enum.Parse(typeof(Occupation), Console.ReadLine(), true);

        player.Occupation = occupation;

        switch (occupation)
        {
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

        Console.WriteLine("What is the race of your character? Elf, Human, Dwarf, or Halfling?");
        Race race = (Race)Enum.Parse(typeof(Race), Console.ReadLine(), true);
        player.Race = race;

        Console.WriteLine($"You have chosen {player.Race} as your race.");

        return player;
    }
}