using System;
public class Character
{
    //commented out the race and occupation till the methods have been created
    public string name { get; set; }
    //public Race? race { get; set; }= null;
    //public Occupation? occupation { get; set; } = null;
    public int strength { get; set; }
    public int agility { get; set; }
    public int health { get; set; }
     public Weapon? weapon { get; set; } = null;

    public Character(string name, string race, string occupation)
    {
        this.name = name;
        //this.race = null;
        //this.occupation = null;
        this.strength = 0;
        this.agility = 0;
        this.health = 0;
        this.weapon = null;
    }

    public string MissedMeTaunt()
    {
        return "The dragon missed you.";
    }
    //once the dragon class is created, we can add the dragon name to the taunt
    //public string MissedMeTaunt(Dragon dragon)
    public string WasHitTaunt()
    {
        return $"(Dragon.name) hits you.";
    }

    public string DisplayStats()
    {
        return $"Name: {name}\n" +
              // $"Race: {race}\n" +
              // $"Occupation: {occupation}\n" +
               $"Strength: {strength}\n" +
               $"Agility: {agility}\n" +
               $"Health: {health}\n" +
               $"Weapon: {(weapon != null ? weapon.Type : "None")}";
    }
}

  