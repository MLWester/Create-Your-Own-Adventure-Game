using System;
public class Combat
{
    private static Random random = new Random();
    public static void AttackSequence(Character player, Dragon dragon)
    {
        Die die = new Die();
        List<string> dragonHitReplies = new List<string>
        {
            "The dragon roars in pain!",
            "The dragon lets out a furious growl!",
            "The dragon screeches in anger!"
        };
        List<string> dragonMissTaunts = new List<string>
        {
            "You call that an attack, {0}?",
            "Is that all you've got, {0}?",
            "You swing like a drunken dwarf, {0}!"
        };
        List<string> playerTaunts = new List<string>
        {
            "You can't catch me, you overgrown lizard!",
            "Is that the best you can do?",
            "You fight like a baby dragon!"
        };

        while (true) //  Loop for repeated attacks
        {
            Console.WriteLine($"You prepare yourself to attack the dragon with your weapon. As a {player.GetOccupation()} you withdraw your {player.GetWeapon().Type}. You attack.");
            // Display weapon ASCII art
            switch (player.GetOccupation())
            {
                case Occupation.Fighter:
                    Console.WriteLine(" -)=====>");
                    break;
                case Occupation.Magician:
                    Console.WriteLine(" zap~~~~~~");
                    break;
                case Occupation.Thief:
                    Console.WriteLine(" -)==>");
                    break;
                case Occupation.Archer:
                    Console.WriteLine(" }    -->");
                    break;
            }

            // Roll for player's attack
            int playerAttackRoll = die.Roll(20);
            if (playerAttackRoll <= player.GetStrength())
            {
                Console.WriteLine($"You hit {dragon.GetName()}.");

                // Dragon's defense
                int dragonDefenseRoll = die.Roll(20);
                Console.WriteLine($"{dragon.GetName()} rolled {dragonDefenseRoll} to defend.");
                if (dragonDefenseRoll <= dragon.GetAgility())
                {
                    Console.WriteLine($"{dragon.GetName()} successfully defends your attack.");
                    Console.WriteLine(string.Format(dragonMissTaunts[random.Next(dragonMissTaunts.Count)], player.GetRace())); //random taunt
                }
                else
                {
                    // Calculate damage
                    int damage = die.Roll(player.GetWeapon().MaxDamage);
                    dragon.SetHealth(dragon.GetHealth() - damage);
                    Console.WriteLine($"The dragon failed to defend your attack. Your weapon delivers {damage} damage points. The dragon’s health points are now {dragon.GetHealth()}.");

                    if (dragon.GetHealth() <= 0)
                    {
                        Console.WriteLine($"With the last words of ‘Arggg!’, you have defeated the dragon.");
                        return; // End game.  
                    }
                    else
                    {
                        Console.WriteLine(dragonHitReplies[random.Next(dragonHitReplies.Count)]); //random reply
                    }
                }
            }
            else
            {
                Console.WriteLine($"You missed {dragon.GetName()}.");
            }

            // Dragon's turn to attack.
            Console.WriteLine($"{dragon.GetName()} attacks you!");
            int dragonAttackRoll = die.Roll(20);
            Console.WriteLine($"{dragon.GetName()} rolled {dragonAttackRoll} to attack.");
            if (dragonAttackRoll <= dragon.GetStrength())
            {
                Console.WriteLine($"{dragon.GetName()} hits you.");
                int playerDefenseRoll = die.Roll(20);
                Console.WriteLine($"You rolled {playerDefenseRoll} to defend.");
                if (playerDefenseRoll <= player.GetAgility())
                {
                    Console.WriteLine("You successfully defend the attack.");
                    Console.WriteLine(playerTaunts[random.Next(playerTaunts.Count)]); //random player taunt
                }
                else
                {
                    int damage = die.Roll(20); // Dragon's attack damage roll
                    player.SetHealth(player.GetHealth() - damage);
                    Console.WriteLine($"The dragon's attack delivers {damage} damage points. Your health points are now {player.GetHealth()}.");
                    if (player.GetHealth() <= 0)
                    {
                        Console.WriteLine("You have been defeated!");
                        return; // Game over
                    }
                }
            }
            else
            {
                Console.WriteLine($"The dragon missed you.");
            }

            // Player options: Retreat or Attack
            Console.WriteLine("Options: “r” for retreat and “a” for attack");
            string choice = Console.ReadLine()?.ToLower();
            if (choice == "r")
            {
                Console.WriteLine("You hastily retreat, licking your wounds.");
                return; // Return to main menu (end the attack sequence)
            }
            // If the player chooses "a", the loop continues to the next attack round.
        }
    }
}
