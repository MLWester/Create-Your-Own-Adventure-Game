public class Player : Character
{
    public Occupation? Occupation { get; set; }
    public Weapon? Weapon { get; set; }
    public Race? Race { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Health { get; set; }

    public Player(string name) : base(name)
    {
        Strength = 0;
        Agility = 0;
        Health = 0;
        Weapon = null;
        Occupation = null;
        Race = null;
    }
}
