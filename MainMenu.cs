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
            PlayerChoice();

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
    }
}
