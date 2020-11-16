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
            this.name = name;
            score = 0;
            
        }

        public override void ChooseMove()
        {
            chosenGesture = RoboMove();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(name+" chose "+chosenGesture.name);
            Console.ResetColor();
        }

        public Move RoboMove()
        {
            random = new Random();
            int r = random.Next(0, 5);
            switch (r)
            {
                case 0:
                    return gestures[0];
                case 1:
                    return gestures[1];
                case 2:
                    return gestures[2];
                case 3:
                    return gestures[3];
                case 4:
                    return gestures[4];
            }
            return null;
        }
    }
}
