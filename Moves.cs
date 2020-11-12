using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Moves
    {
        public Players move;
        public List<Moves> attackMethod;

        public Moves(Players move)
        {
            this.move = move;
            attackMethod = new List<Moves>();
        }

       public bool Paper(Players move)
        {
            if(move == Spock)
            {
                Console.WriteLine("Spock has been DISPROVEN");
                return true;
            }
            else if(move == Rock)
            {
                Console.WriteLine("You really thought a rock could defeat my paper?");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Rock(Players move)
        {
            if (move == scissors)
            {
                Console.WriteLine("Only diamond can cut diamond!!");
                return true;
            }
            else if (move == lizard)
            {
                Console.WriteLine("Your lizard was no match for me.");
                ReturnMessage true;
            }
            else
            {
                return false;
            }
        }
        public bool scissors(Players move)
        {
            if(move == paper)
            {
                Console.WriteLine("One scissor to rule them all");
                return true;
            }
            else if(move == spock)
            {
                Console.WriteLine("Sir I'm going to need to see some ID.");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Lizard(Players move)
        {
            if(move == spock)
            {
                Console.WriteLine("HISS");
                return true;
            }
            else if(move == paper)
            {
                Console.WriteLine("hisssss");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Spock(Players move)
        {
            if(move == scissors)
            {
                Console.WriteLine("My Vulcan skin is no match for your earthly weapons");
                return true;
            }
            else if(move == rock)
            {
                Console.WriteLine("Was that supposed to hurt me, human?");
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }
}
