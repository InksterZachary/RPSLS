using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Moves
    {
        public string defeats;
        public List<Moves> attackMethod;

        public Moves(string defeats)
        {
            this.defeats = defeats;
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
    }
}
