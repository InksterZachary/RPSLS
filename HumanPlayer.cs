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
            score = 0;
           
        }
        public override void ChooseMove()
        {
            chosenGesture = HumanMove();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(name + " chose " + chosenGesture.name);
            Console.ResetColor();
        }
        public Move HumanMove()
        {
            Console.WriteLine("Choose a gesture. Your options are:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + gestures[i].name);
            }
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int number)) //After I had a working version, Tony walked me through this more efficient way.
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
        }
    }
}
