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
            chosenGesture = HumanMove();
            Console.WriteLine(name + " chose " + chosenGesture.name);
            //return chosenGesture;
        }
        public Move HumanMove()
        {
            Console.WriteLine("Choose a gesture. Your options are:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + gestures[i].name);
            }
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int number)) //Tony showed me this
            {
                number--;
                if (number >= 0 && number < gestures.Count)
                {
                    return gestures[number];
                }
                else
                {
                    return HumanMove();
                }
            }
            else
            {
                return HumanMove();
            }


            //Console.WriteLine("||Rock | Paper | Scissors | Lizard | Spock||");
            //if (userInput == "Rock")
            //{
            //    return gestures[0];
            //}
            //else if (userInput == "Paper")
            //{
            //    return gestures[1];
            //}
            //else if(userInput == "scissors")
            //{
            //    return gestures[2];
            //}
            //else if(userInput == "Lizard")
            //{
            //    return gestures[3];
            //}
            //else if(userInput == "Spock")
            //{
            //    return gestures[4];
            //}    
            //else
            //{
            //    Console.WriteLine("Please choose an appropriate gesture next time.");
            //    return null;
            //}
        }
    }
}
