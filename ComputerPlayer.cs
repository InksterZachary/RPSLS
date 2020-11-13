using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer : Player
    {
        public Random random;
        public ComputerPlayer(string name) : base(name)//base calls the parent constructor and sends in the required values.
        {
            this.name = "AlIx";
            
        }

        public override void ChooseMove()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock SHOOT");
            chosenGesture = RoboMove();
        }

        public Move RoboMove()
        {
            random = new Random();
            int r = random.Next(0, 6);
            switch (r)
            {
                case 0:
                    return chosenGesture.gesture[0];
                case 1:
                    return chosenGesture.gesture[1];
                case 2:
                    return chosenGesture.gesture[2];
                case 3:
                    return chosenGesture.gesture[3];
                case 4:
                    return chosenGesture.gesture[4];
                case 5:
                    return chosenGesture.gesture[5];
            }
            return null;
        }
    }
}
