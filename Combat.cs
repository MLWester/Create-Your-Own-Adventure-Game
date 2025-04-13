using System;
using System.Collections.Generic;

public class Combat
{
    private static Random random = new Random();

    public static void AttackSequence(Character player, Dragon dragon, Messages messages)
    {
        Die die = new Die();

        while (true)
        {
            Console.WriteLine(string.Format(messages.GetMessage(310), player.GetOccupation(), player.GetWeapon().Type)); // Attack intro
            Console.WriteLine(messages.GetMessage(104).Replace("{0}", player.GetWeapon().AsciiArt)); // Weapon ASCII Art

            // Player attack roll
            int playerAttackRoll = die.Roll(20);
            if (playerAttackRoll <= player.GetStrength())
            {
                Console.WriteLine(string.Format(messages.GetMessage(323), dragon.GetName())); // You hit the dragon

                // Dragon defense
                int dragonDefenseRoll = die.Roll(20);
                if (dragonDefenseRoll <= dragon.GetAgility())
                {
                    Console.WriteLine(string.Format(messages.GetMessage(312), dragon.GetName()));
                    Console.WriteLine(messages.GetMessage(301 + random.Next(0, 4))); // Dragon taunt 301-304
                }
                else
                {
                    int damage = die.Roll(player.GetWeapon().MaxDamage);
                    dragon.SetHealth(dragon.GetHealth() - damage);
                    Console.WriteLine(string.Format(messages.GetMessage(313), damage, dragon.GetHealth()));

                    if (dragon.GetHealth() <= 0)
                    {
                        Console.WriteLine(messages.GetMessage(314));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(messages.GetMessage(305 + random.Next(0, 4))); // Dragon was hit taunts 305-308
                    }
                }
            }
            else
            {
                Console.WriteLine(string.Format(messages.GetMessage(311), dragon.GetName()));
            }

            // Dragon's turn to attack
            Console.WriteLine(string.Format(messages.GetMessage(321), dragon.GetName())); // Dragon's turn 
            int dragonAttackRoll = die.Roll(20);
            if (dragonAttackRoll <= dragon.GetStrength())
            {
                Console.WriteLine(string.Format(messages.GetMessage(315), dragon.GetName())); // Dragon hits you
                int playerDefenseRoll = die.Roll(20);
                if (playerDefenseRoll <= player.GetAgility())
                {
                    Console.WriteLine(messages.GetMessage(316));
                    Console.WriteLine(messages.GetMessage(301 + random.Next(0, 4))); // Player taunt
                }
                else
                {
                    int damage = die.Roll(dragon.GetWeapon().MaxDamage);
                    player.SetHealth(player.GetHealth() - damage);
                    Console.WriteLine(string.Format(messages.GetMessage(317), damage, player.GetHealth()));

                    if (player.GetHealth() <= 0)
                    {
                        Console.WriteLine(messages.GetMessage(320)); // Player is dead
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine(messages.GetMessage(322)); // Dragon misses
            }

            // Player decision to retreat or attack
            string? choice;
            do
            {
                Console.WriteLine(messages.GetMessage(319)); // Ask if player wants to continue
                choice = Console.ReadLine()?.ToLower();

                if (choice == "r")
                {
                    Console.WriteLine(messages.GetMessage(318));
                    return;
                }
                else if (choice != "a")
                {
                    Console.WriteLine(messages.GetMessage(408)); // Invalid input
                }

            } while (choice != "a");
        }
    }
}
