﻿using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleBlue("********NINJA: REMOTE ISLAND********");

            Hero player = PlayerSetup();
            
            ConsoleBlue($"You, {player.Name}, decided to take cruise around the Pacific!  Unfortunately, there was a incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must get to the beach so you can send out a distress signal and get back home.  What dangers and mysteries lurk within the jungle island?  Will you make it to the beach safely?  Is this the island with all the dinosaurs?\n\nPress Enter to Start");

            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

            //write a method that will create other team mates.
            Hero teammate = AddTeammate();
            // make a game(while) loop to run your game
            while(player.Health!=0)
            {
                // player.Attack()
            }
        }

        static void ConsoleBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the hero you would like to be:\n1. Ninja: Highest Speed\n2. Wizard: Highest Intelligence\n3. Sensei: Highest Strength");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Wizard wizardHero = new Wizard(name);
                    return wizardHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Sensei senseiHero = new Sensei(name);
                    return senseiHero;
            }
            return null;
        }

        static Hero AddTeammate()
        {
            Console.WriteLine("Now it's time to choose a teammate!\n Press Enter to Choose:");
            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Who will you choose as your teammate?\n1. Ninja: The Ninja has super speed, can throw shurkeins AND can steal health from unsuspecting enemies!\n2. Wizard:The Wizard is a genius, can throw fireballs AND can perform magic on unsuspecting enemies!\n3. Sensei:The Sensei has super strength, can slap and chop AND can meditate health back!");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    ConsoleBlue($"Great choice, {name}! You've decided to bring the Ninja!\n\nThe Ninja has super speed, can throw shurkeins AND can steal health from unsuspecting enemies!\n\nNow that you have your teammate, Press Enter to get started:");
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Wizard wizardHero = new Wizard(name);
                    ConsoleBlue($"Great choice, {name}! You've decided to bring the Wizard!\n\nThe Wizard is a genius, can throw fireballs AND can perform magic on unsuspecting enemies!\n\nNow that you have your teammate, Press Enter to get started:");
                    return wizardHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Sensei senseiHero = new Sensei(name);
                    ConsoleBlue($"Great choice, {name}! You've decided to bring the Sensei!\n\nThe Sensei has super strength, can slap and chop AND can meditate health back!\n\nNow that you have your teammate, Press Enter to get started:");
                    return senseiHero;
            }
            return null;

        }
    }
}
