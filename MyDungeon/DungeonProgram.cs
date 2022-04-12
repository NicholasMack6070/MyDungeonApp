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
            Console.Title = "U..somethingF..somethingO..something";

            Console.WriteLine("Lights flash before your eyes. As you slowing awaken, head pounding, you try to rise to your feet.\nMind foggy, you recall brief events before awaking...You remember being attacked and defensless then black...\nYou look down at your body and see that your armor is still in tact. \"Barely a scratch, where am I?\" \nOnce you regain your senses you check your vitals, shields, and life support.\n\"Everything seems good...Now time to find my way out of here...\"");
            //TODO 1.Create Player & Weapon
            //2.Create a loop for the game
            bool exit = false;

            do
            {
                //TODO 3.Create Rooms - making a method to generate a room description
                Console.WriteLine("You have entered { } room\n");
                Console.WriteLine(GetRoom());

                //TODO 4.Create a Monster
                //TODO 5.Create a Loop for the menu
                bool reload = false;

                do
                {
                    // 6.Provide the user with a menu of options
                    Console.WriteLine("\nPlease select an action\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");
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
                            Console.WriteLine("Running Away!");
                            //TODO 10. Handle the user running away & the monster getting a free attack
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //TODO 11. Print out player info
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            //TODO 12. Print out monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Exiting Game");
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
            {
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
                "Example",
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }

    }//class
}//namespace
