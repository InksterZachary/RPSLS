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
        }
        public override void ChooseMove()
        {
            chosenGesture = HumanMove();
        }
        public Move HumanMove()
        {
            Console.WriteLine("Choose a gesture. Your options are:");
            Console.WriteLine("||Rock | Paper | Scissors | Lizard | Spock||");
            string userInput = Console.ReadLine();
            if (userInput == "Rock")
            {
                return chosenGesture.gesture[0];
            }
            else if (userInput == "Paper")
            {
                return chosenGesture.gesture[1];
            }
            else if(userInput == "scissors")
            {
                return chosenGesture.gesture[2];
            }
            else if(userInput == "Lizard")
            {
                return chosenGesture.gesture[3];
            }
            else if(userInput == "Spock")
            {
                return chosenGesture.gesture[4];
            }    
            else
            {
                Console.WriteLine("Please choose an appropriate gesture next time.");
                return null;
            }
        }
    }
}
