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
            score = 0;
        }

        public override void ChooseMove()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock SHOOT");
            RoboMove(); 
        }

        public Move RoboMove()
        {
            random = new Random();
            int r = random.Next(0, 5);
            switch (r)
            {
                case 0:
                    Console.WriteLine(gesture[0].name);
                    return gesture[0];
                case 1:
                    Console.WriteLine(gesture[1].name);
                    return gesture[1];
                case 2:
                    Console.WriteLine(gesture[2].name);
                    return gesture[2];
                case 3:
                    Console.WriteLine(gesture[3].name);
                    return gesture[3];
                case 4:
                    Console.WriteLine(gesture[4].name);
                    return gesture[4];
            }
            return null;
        }
    }
}
