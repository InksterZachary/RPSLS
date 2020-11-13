using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {

        public HumanPlayer(string name) : base(name)
        {
            //name = Console.ReadLine();
            score = 0;
        }
        public override void ChooseMove()
        {
           HumanMove();
        }
        public Move HumanMove()
        {

            bool validInput = false;
            while (!validInput)
            {

                Console.WriteLine("Choose a gesture. Your options are:");
                Console.WriteLine("||Rock | Paper | Scissors | Lizard | Spock||");
                string userInput = Console.ReadLine();
                if (userInput == "Rock")
                {
                    return gesture[0];
                }
                else if (userInput == "Paper")
                {
                    return gesture[1];
                }
                else if(userInput == "scissors")
                {
                    return gesture[2];
                }
                else if(userInput == "Lizard")
                {
                    return gesture[3];
                }
                else if(userInput == "Spock")
                {
                    return gesture[4];
                }    
                else
                {
                    Console.WriteLine("Please choose an appropriate gesture next time.");
                    return null;
                }
            }
            return null;
        }
    }
}
