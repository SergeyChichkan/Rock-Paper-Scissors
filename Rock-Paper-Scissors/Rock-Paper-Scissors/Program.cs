using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = "Y";

            while (answer == "Y")
            {

            Console.WriteLine("This is classic Rock-Paper-Scissors game." +
                              "\nTake 3 points to win." +
                              "\nGood luck!");

            //variables to store the number of victories
            int p = 0;
            int c = 0;
            string[] weapons = { "Rock", "Paper", "Scissors" };
                       
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                //Console.WriteLine(enemy_weapon);
                
                Console.WriteLine("\n\n1 - Rock, 2 - Paper, 3 - Scissors" +
                "\n\nChoose your weapon:");

                Console.ResetColor();

                int enemy_weapon = new Random().Next(1, 4);

                string weapon = Console.ReadLine();

                try
                {
                    int index = Convert.ToInt32(weapon);
                    Console.WriteLine("You choose {0}.", weapons[index - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Fail! Please, input 1, 2 or 3.");
                }

                //matching the weapons
                switch (weapon)
                {
                    case "1":

                        if (enemy_weapon == 1)
                        {
                            Console.WriteLine("Computer choose Rock too.\nDraw.");
                        }
                        else if (enemy_weapon == 2)
                        {
                            Console.WriteLine("Computer choose Paper.\nYou lose...");
                            c++;
                        }
                        else if (enemy_weapon == 3)
                        {
                            Console.WriteLine("Computer choose Scissors.\nYou WIN!!!");
                            p++;
                        }
                        break;

                    case "2":

                        if (enemy_weapon == 1)
                        {
                            Console.WriteLine("Computer choose Rock.\nYou WIN!!!");
                            p++;
                        }
                        else if (enemy_weapon == 2)
                        {
                            Console.WriteLine("Computer choose Paper too.\nDraw.");
                        }
                        else if (enemy_weapon == 3)
                        {
                            Console.WriteLine("Computer choose Scissors.\nYou lose...");
                            c++;
                        }
                        break;

                    case "3":

                        if (enemy_weapon == 1)
                        {
                            Console.WriteLine("Computer choose Rock.\nYou lose...");
                            c++;
                        }
                        else if (enemy_weapon == 2)
                        {
                            Console.WriteLine("Computer choose Paper.\nYou WIN!!!");
                            p++;
                        }
                        else if (enemy_weapon == 3)
                        {
                            Console.WriteLine("Computer choose Scissors too.\nDraw.");
                        }
                        break;

                }

            }
            while ((p < 3) && (c < 3));

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (p == 3)
                Console.WriteLine("\nCONGRATULATIONS!!!\nYou win in this hard battle!");

            else if (c == 3)
                Console.WriteLine("\nSorry, but you not a winner...\nTry again.");

                 Console.ResetColor();
                
                 Console.WriteLine("\nWant to play again?\nEnter 'Y' if you want to conyinue or any another to break.");

                 answer = Console.ReadLine();

                 Console.Clear();
           
            }

            Console.WriteLine("Thank you for game!");
            
            Console.ReadKey();
        }
    }
}
