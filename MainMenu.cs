using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class MainMenu
    {
       
        public MainMenu()
        {

        }

        public void WelcomeRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("In this game you will have to choose from\n" +
                "the list of gestures to faceoff against your opponent!\n" +
                "");
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("Rock beats Lizard and Scissors");
            Console.WriteLine("Paper beats Spock and Rock");
            Console.WriteLine("Scissors beats Lizard and Paper");
            Console.WriteLine("Lizard beats Spock and Paper");
            Console.WriteLine("Spock beats Rock and Scissors");
            Console.WriteLine("Please press any key to continue.");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear(); 
        }
        public int PlayerChoice()
        {
            int input;
            do
            {
                Console.WriteLine("Please type a command: \n" +
                    "'1' for Player VS Player \n" +
                    "'2' for Player vs Computer \n" +
                    "'3' to watch the computers go at it");
                input = int.Parse(Console.ReadLine());
            }
            while (input != 1 && input != 2 && input != 3);
            if (input == 1)
            {
                return 1;
            }
            else if(input == 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }     
        public bool NewGame()
        {
            Console.WriteLine("\n" +
                "Would you like to play again?\n" +
                "Y/N");
            string userInput = Console.ReadLine();
            while(userInput != "Y" && userInput != "y" && userInput != "N" && userInput != "n")
            {
                Console.WriteLine("\n" +
                "Would you like to play again?\n" +
                "Y/N");
                userInput = Console.ReadLine();
            }
            if (userInput == "Y" || userInput == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
