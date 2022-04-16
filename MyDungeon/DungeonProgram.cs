using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeon
{
    class DungeonProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Elden Ring";

            Console.WriteLine("You rise from your grave and await your destiny...\n");
            Console.WriteLine("Character Creation:\n");
            //TODO 1.Create Player & Weapon
            //2.Create a loop for the game
            bool exit = false;

            do
            {
                //TODO 3.Create Rooms - making a method to generate a room description
                Console.WriteLine("Once you grab your armor and weapon of choice, you exit the\n cave that your grave was inside, and find your first boss\n");
                Console.WriteLine(GetRoom());

                //TODO 4.Create a Monster
                //TODO 5.Create a Loop for the menu
                bool reload = false;

                do
                {
                    // 6.Provide the user with a menu of options
                    Console.WriteLine("\nPlease select an action\n" +
                        "A) Attack\n" +
                        "R) Flee\n" +
                        "P) Player Stats\n" +
                        "M) Monster Stats\n" +
                        "X) Exit Game\n");
                    //7.Catch the user's choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();
                    //8.Build out the switch to handle the user's choice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO 9. Handle the combat logic & what happens if the player wins
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Flee!");
                            //TODO 10. Handle the user running away & the monster getting a free attack
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Stats:");
                            //TODO 11. Print out player info
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Boss Stats:");
                            //TODO 12. Print out monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Saving Game............Exiting Game");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid action and try again.");
                            break;
                    }
                    
                    //TODO 13.Check the player's life
                } while (!exit && !reload);



                //TODO 14.State the player's score

            } while (!exit);



        }//svm

        private static string GetRoom()
        {
            string[] rooms =
            {//TODO ADD DESCRIPTIONS FOR ROOMS!
                "BossRoom1",
                "BossRoom2",
                "BossRoom3",
                "BossRoom4",
                "BossRoom5",
                "BossRoom6",
                "BossRoom7",
                "BossRoom8",
                "BossRoom9",
                "BossRoom10",
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }

    }//class
}//namespace
