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
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("In this game you will have to choose from the list of gestures to faceoff against your opponent!");
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("Rock beats Lizard and Scissors");
            Console.WriteLine("Paper beats Spock and Rock");
            Console.WriteLine("Scissors beats Lizard and Paper");
            Console.WriteLine("Lizard beats Spock and Paper");
            Console.WriteLine("Spock beats Rock and Scissors");
            Console.WriteLine("Please press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public bool PlayerChoice()
        {
            int input;
            do
            {
                Console.WriteLine("Please type '1' for Player VS Player or '2' for Player vs Computer");
                input = int.Parse(Console.ReadLine());
            }
            while (input != 1 && input != 2);
            if (input == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            //public bool NewGame()
            //{
           
                //Console.WriteLine("Would you like to play again?");
           //}
        
    }
}
